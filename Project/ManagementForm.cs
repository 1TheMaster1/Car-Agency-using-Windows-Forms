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
    public partial class ManagementForm : Form
    {
        Employee employeeCurrent = new Employee();
        bool check = true;
        public static MainMenu prevForm = new MainMenu();     

        public ManagementForm(Employee employee, MainMenu mainMenu)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
            prevForm = mainMenu;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);
            int salary = Convert.ToInt32(salaryTextBox.Text);
            Employee employee = new Employee();

            switch (jobComboBox.SelectedIndex)
            {
                case 0:
                    employee = new Management(name, age, salary);
                    Employee.employeeList.Add(employee);
                    MessageBox.Show("Added new \"management\"");
                    break;
                case 1:
                    employee = new Sales(name, age, salary);
                    Employee.employeeList.Add(employee);
                    MessageBox.Show("Added new \"sales\"");
                    break;
                case 2:
                    employee = new CommissionedSales(name, age, salary);
                    Employee.employeeList.Add(employee);
                    MessageBox.Show("Added new \"commissioned sales\"");
                    break;
                case 3:
                    employee = new Finance(name, age, salary);
                    Employee.employeeList.Add(employee);
                    MessageBox.Show("Added new \"finance\"");
                    break;
                case 4:
                    employee = new Technician(name, age, salary);
                    Employee.employeeList.Add(employee);
                    MessageBox.Show("Added new \"technician\"");
                    break;
                default:
                    MessageBox.Show("Choose a job"); break;
            }
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeDisplayList.Items.Clear();
            employeeDisplayList.Items.Add("ID\tName\tAge\tSalary\tJob");
            employeeDisplayList.Items.Add("-----------------------------------------------------------");
            foreach (var employee in Employee.employeeList)
            {
                if (employee.Name != "admin")
                    employeeDisplayList.Items.Add(employee);
            }
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            int x = employeeDisplayList.SelectedIndex;
            if (x > -1)
                Employee.employeeList.RemoveAt(x - 1);
            else
                MessageBox.Show("Select an item");

            updateEmployeeButton_Click(sender, e);
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string name = customerNameTextBox.Text;
            int age = Convert.ToInt32(customerAgeTextBox.Text);
            string phone = customerNumberTextBox.Text;
            Customer customer = new Customer(name, age, phone);
            Customer.customerList.Add(customer);
            MessageBox.Show("Added new \"customer\"");
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            customerDisplayList.Items.Clear();
            customerDisplayList.Items.Add("ID\tName\tAge\tPhone Number\tNo. of Purchases\tTotal Payment");
            customerDisplayList.Items.Add("------------------------------------------------------------------------------------");
            foreach (var customer in Customer.customerList)
            {
                customerDisplayList.Items.Add(customer);
            }
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            int x = customerDisplayList.SelectedIndex;
            if (x > -1)
                Customer.customerList.RemoveAt(x - 2);
            else
                MessageBox.Show("Select an item");

            updateCustomerButton_Click(sender, e);
        }

        private void employeeResetButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in employeeGroupBox.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                    if (textBox != null)
                        if (textBox.Text != string.Empty)
                        {
                            textBox.Text = string.Empty;
                        }
                }
            }
        }

        private void customerResetButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in customerGroupBox.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                    if (textBox != null)
                        if (textBox.Text != string.Empty)
                        {
                            textBox.Text = string.Empty;
                        }
                }
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
