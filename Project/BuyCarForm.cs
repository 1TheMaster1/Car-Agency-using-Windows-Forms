using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class BuyCarForm : Form
    {
        Employee employeeCurrent = new Employee();
        Inventory inventoryCurrent = new Inventory();
        Car carCurrent = new Car();
        int amount = 0;
        int payment = 0;
        public static InventoryForm prevForm = new InventoryForm();

        public BuyCarForm(Employee employee, Inventory inventory, InventoryForm inventoryForm)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
            inventoryCurrent = inventory;
            carCurrent = inventoryCurrent.Car;
            prevForm = inventoryForm;
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
            CompanyCarPurchaseInvoice invoice = new CompanyCarPurchaseInvoice(payment, employeeCurrent, amount, carCurrent);
            CompanyCarPurchaseInvoice.companyCarPurchaseInvoiceList.Add(invoice);
            inventoryCurrent.Quantity += amount;
            noButton_Click(sender, e);
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
