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
        int hours = 0;
        double carTypeRate;
        double washPackageRate;





        public ServiceForm(Employee employee)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
        }

        private void carTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = carTypecomboBox.SelectedIndex;
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
                case 0: washPackageRate = 1; PackageDescriptionTextBox.Text = "Washing with soap and water only"; break;
                case 1: washPackageRate = 1.5; PackageDescriptionTextBox.Text = "Washing with soap and water and Detailing the interior "; break;
                case 2: washPackageRate = 2; PackageDescriptionTextBox.Text = "Washing with soap and water ,Detailing the interior and Waxing with buffing the car "; break;
                default: carTypeRate = 0; break;
            }
        }

        private void HoursTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HoursTextBox.Text != "")
            {
                hours = Convert.ToInt32(HoursTextBox.Text);
            }
            else { hours = 0; }
            double total = hours * CostPerHour * carTypeRate * washPackageRate;
            Amount.Text = Convert.ToString(total);
        }


        private void PackageDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void payNowButton_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Click(object sender, EventArgs e)
        {
        }
    }
}
