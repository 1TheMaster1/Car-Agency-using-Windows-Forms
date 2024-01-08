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
        bool check = true;
        public static StartWindow prevForm = new StartWindow();

        public MainMenu() { }
        public MainMenu(Employee employee, StartWindow startWindow)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
            prevForm = startWindow;
            userLabel2.Text = employeeCurrent.Name + " (" + employeeCurrent.Role + ")";
        }

        private void managementButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Role == "management")
            {
                ManagementForm managementForm = new ManagementForm(employeeCurrent, this);
                this.Hide();
                managementForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Role == "management" || employeeCurrent.Role == "sales")
            {
                InventoryForm inventoryForm = new InventoryForm(employeeCurrent, this);
                this.Hide();
                inventoryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Role == "management" || employeeCurrent.Role == "finance")
            {
                FinanceForm financeForm = new FinanceForm(employeeCurrent, this);
                this.Hide();
                financeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            if (employeeCurrent.Role == "management" || employeeCurrent.Role == "technician")
            {
                ServiceForm serviceForm = new ServiceForm(employeeCurrent, this);
                serviceForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access");
            }
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
