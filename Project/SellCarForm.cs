using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project
{
    public partial class SellCarForm : Form
    {
        Employee employeeCurrent = new Employee();
        Inventory inventoryCurrent = new Inventory();
        Car carCurrent = new Car();
        int amount = 0;
        int payment = 0;
        public static InventoryForm prevForm = new InventoryForm();

        public SellCarForm(Employee employee, Inventory inventory, InventoryForm inventoryForm)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
            inventoryCurrent = inventory;
            carCurrent = inventoryCurrent.Car;
            prevForm = inventoryForm;

            customerDisplayList.Items.Clear();
            customerDisplayList.Items.Add("ID\tName\tAge\tPhone Number\tNo. of Purchases\tTotal Payment");
            customerDisplayList.Items.Add("------------------------------------------------------------------------------------");
            foreach (var customer in Customer.customerList)
            {
                customerDisplayList.Items.Add(customer);
            }
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (amountTextBox.Text != string.Empty) 
                amount = Convert.ToInt32(amountTextBox.Text);
            payment = amount * carCurrent.SellingPrice;
            paymentLabel.Text = "Total Payment : " + payment;
            if (amountTextBox.Text == string.Empty)
                paymentLabel.Text = "Total Payment : ";
        }

        private void yesButton_Click(object sender, EventArgs e)
        {

            if (amountTextBox.Text == string.Empty)
            {
                MessageBox.Show("Type an amount");
                return;
            }
            int x = customerDisplayList.SelectedIndex;
            int idcust = Customer.customerList[x - 2].ID;
            if (x > -1)
            {
                int custID = idcust;
                int empID = employeeCurrent.ID;
                int carID = carCurrent.ID;
                int invoiceTP = payment;
                string invoiceType = "purchase";
                int id = 0;

                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into Invoices values (@empID,@customerID,@carID, @invoiceTP, @invoiceType)", cnn);
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@customerID", custID);
                cmd.Parameters.AddWithValue("@carID", carID);
                cmd.Parameters.AddWithValue("@invoiceTP", invoiceTP);
                cmd.Parameters.AddWithValue("@invoiceType", invoiceType);
                cmd.ExecuteNonQuery();
                string query = "SELECT TOP 1 * FROM Invoices ORDER BY invoiceCustomerID DESC";
                SqlCommand cmdNew = new SqlCommand(query, cnn);
                SqlDataReader reader = cmdNew.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(reader.GetOrdinal("invoiceCustomerID"));
                }
                cnn.Close();
                
                Customer customer = Customer.customerList[x - 2];
                customer.Purchase(payment, amount);
                CustomerCarPurchaseInvoice invoice = new CustomerCarPurchaseInvoice(id ,payment, employeeCurrent, customer, carCurrent);
                CustomerCarPurchaseInvoice.customerCarPurchaseInvoiceList.Add(invoice);
                inventoryCurrent.Quantity -= amount;
                if (employeeCurrent is CommissionedSales)
                {
                    CommissionedSales commissionedSales = (CommissionedSales)employeeCurrent;
                    commissionedSales.NumberOfSales ++;
                }
                MessageBox.Show("Purchase Complete");
                noButton_Click(sender, e);
            }
            else
                MessageBox.Show("Select a customer");
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            prevForm.Show();
        }

        static int GetMaxPrimaryKeyValue(string connectionString, string tableName, string primaryKeyColumnName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT MAX({primaryKeyColumnName}) FROM {tableName}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    return (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                }
            }
        }
        static void InsertNewRecord(string connectionString, string tableName, string primaryKeyColumnName, int newPrimaryKeyValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO {tableName} ({primaryKeyColumnName}, ...) VALUES ({newPrimaryKeyValue}, ...)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the INSERT command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
