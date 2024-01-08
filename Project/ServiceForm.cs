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
    public partial class ServiceForm : Form
    {
        Employee employeeCurrent = new Employee();
        int CostPerHour = 10;
        double total;
        int hours = 0;
        double carTypeRate;
        double washPackageRate;
        bool check = true;
        public static MainMenu prevForm = new MainMenu();

        public ServiceForm(Employee employee, MainMenu mainMenu)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
            prevForm = mainMenu;
        }

        private void carTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = carTypeComboBox.SelectedIndex;
            switch (index)
            {
                case 0: carTypeRate = 1; break;
                case 1: carTypeRate = 1.5; break;
                case 2: carTypeRate = 2; break;
                case 3: carTypeRate = 2.5; break;
                case 4: carTypeRate = 3; break;
                default: carTypeRate = 0; break;
            }
        }

        private void washPackageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = washPackageComboBox.SelectedIndex;
            switch (index)
            {
                case 0: washPackageRate = 1; packageDescriptionTextBox.Text = "Washing with soap and water only"; break;
                case 1: washPackageRate = 1.5; packageDescriptionTextBox.Text = "Washing with soap and water and Detailing the interior "; break;
                case 2: washPackageRate = 2; packageDescriptionTextBox.Text = "Washing with soap and water ,Detailing the interior and Waxing with buffing the car "; break;
                default: carTypeRate = 0; break;
            }
        }

        private void HoursTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hoursTextBox.Text != "")
            {
                hours = Convert.ToInt32(hoursTextBox.Text);
            }
            else { hours = 0; }
            total = hours * CostPerHour * carTypeRate * washPackageRate;
            paymentAmountLabel.Text = "Payment Amount : " + total;
        }

        private void payNowButton_Click(object sender, EventArgs e)
        {
            ServicePurchaseInvoice.payment += (int)total;
            MessageBox.Show("Done Successfully");
            backButton_Click(sender, e);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            check = false;
            this.Hide();
            prevForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && check)
            {
                if (MessageBox.Show("Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                e.Cancel = true;
            }
            check = true;
        }
    }
}
