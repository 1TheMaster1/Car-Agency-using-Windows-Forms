using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (x > -1)
            {
                Customer customer = Customer.customerList[x - 2];
                customer.Purchase(payment, amount);
                CustomerCarPurchaseInvoice invoice = new CustomerCarPurchaseInvoice(payment, employeeCurrent, amount, customer, carCurrent);
                CustomerCarPurchaseInvoice.customerCarPurchaseInvoiceList.Add(invoice);
                inventoryCurrent.Quantity -= amount;
                if (employeeCurrent is CommissionedSales)
                {
                    CommissionedSales commissionedSales = (CommissionedSales)employeeCurrent;
                    commissionedSales.NumberOfSales ++;
                }
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
    }
}
