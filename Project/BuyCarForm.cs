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
        Car carCurrent = new Car();
        int amount = 0;
        int payment = 0;

        public BuyCarForm(Employee employee, Car car)
        {
            InitializeComponent();
            employeeCurrent = employee;
            carCurrent = car;
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
        }

        private void noButton_Click(object sender, EventArgs e)
        {

        }
    }
}
