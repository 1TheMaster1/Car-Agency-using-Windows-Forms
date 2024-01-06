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
    public partial class MainMenu : Form
    {
        Employee employeeCurrent = new Employee();
        public static StartWindow prevStarWindow = new StartWindow();

        public MainMenu(Employee employee, StartWindow startWindow)
        {
            InitializeComponent();
            employeeCurrent = employee;
            prevStarWindow = startWindow;
            userLabel2.Text = employeeCurrent.Name + " (" + employeeCurrent.Authority + ")";
        }

        private void managementButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Authority == "management")
            {
                ManagementForm managementForm = new ManagementForm(employeeCurrent);
                managementForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Authority == "management" || employeeCurrent.Authority == "sales")
            {
                InventoryForm inventoryForm = new InventoryForm(employeeCurrent);
                inventoryForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Authority == "management" || employeeCurrent.Authority == "finance")
            {
                FinanceForm financeForm = new FinanceForm(employeeCurrent);
                financeForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Authority == "management" || employeeCurrent.Authority == "technician")
            {
                ServiceForm serviceForm = new ServiceForm(employeeCurrent);
                serviceForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            prevStarWindow.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            prevStarWindow.Show();
        }
    }
}
