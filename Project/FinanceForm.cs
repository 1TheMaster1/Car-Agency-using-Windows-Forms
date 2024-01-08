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
    public partial class FinanceForm : Form
    {
        Employee employeeCurrent = new Employee();
        int profit = 0;
        int revenue = 0;
        int expenses = 0;
        int sales = 0;
        int service = 0;
        int salaries = 0;
        int carCosts = 0;
        int rent = 0;
        int other = 0;
        bool check = true;
        public static MainMenu prevForm = new MainMenu();

        public FinanceForm(Employee employee, MainMenu mainMenu)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
            prevForm = mainMenu;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in revenueGroupBox.Controls)
                {
                    if (c is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                        if (textBox != null)
                        {
                            if (textBox.Text == string.Empty)
                            {
                                throw new EmptyCellException();
                            }
                            if (Convert.ToInt32(textBox.Text) <= 0)
                            {
                                throw new NegativeNumberException();
                            }
                        }                            
                    }
                }
                foreach (Control c in expensesGroupBox.Controls)
                {
                    if (c is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                        if (textBox != null)
                        {
                            if (textBox.Text == string.Empty)
                            {
                                throw new EmptyCellException();
                            }
                            if (Convert.ToInt32(textBox.Text) <= 0)
                            {
                                throw new NegativeNumberException();
                            }
                        }
                    }
                }
                sales = Convert.ToInt32(salesTextBox.Text);
                service = Convert.ToInt32(serviceTextBox.Text);
                salaries = Convert.ToInt32(salariesTextBox.Text);
                carCosts = Convert.ToInt32(carCostsTextBox.Text);
                rent = Convert.ToInt32(rentTextBox.Text);
                other = Convert.ToInt32(otherTextBox.Text);

                revenue = sales + service;
                expenses = salaries + carCosts + rent + other;
                profit = revenue - expenses;
                revenueLabel.Text = "Total Revenue : " + revenue;
                expensesLabel.Text = "Total Expenses : " + expenses;
                profitLabel.Text = "Profit Amount : " + profit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            foreach (Invoice invoice in CustomerCarPurchaseInvoice.customerCarPurchaseInvoiceList)       
                sales += invoice.Payment;            
            //foreach (Invoice invoice in ServicePurchaseInvoice.servicePurchaseInvoiceList)           
                //service += invoice.Payment;           
            //foreach (Invoice invoice in SalaryInvoice.salaryInvoiceList)            
                //salaries += invoice.Payment;
            foreach (Invoice invoice in CompanyCarPurchaseInvoice.companyCarPurchaseInvoiceList)            
                carCosts += invoice.Payment;
            foreach (Employee employee in Employee.employeeList)
                salaries += employee.GetSalary();
            service = ServicePurchaseInvoice.payment;
            rent = 10000;
            int random = new Random().Next(1000, 10000);
            other = random;

            salesTextBox.Text = sales.ToString();
            serviceTextBox.Text = service.ToString();
            salariesTextBox.Text = salaries.ToString();
            carCostsTextBox.Text = carCosts.ToString();
            rentTextBox.Text = rent.ToString();
            otherTextBox.Text = other.ToString();

            revenue = sales + service;
            expenses = salaries + carCosts + rent + other;
            profit = revenue - expenses;
            revenueLabel.Text = "Total Revenue : " + revenue;
            expensesLabel.Text = "Total Expenses : " + expenses;
            profitLabel.Text = "Profit Amount : " + profit;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in revenueGroupBox.Controls)
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
            foreach (Control c in expensesGroupBox.Controls)
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
            revenueLabel.Text = "Total Revenue : ";
            expensesLabel.Text = "Total Expenses : ";
            profitLabel.Text = "Profit Amount : ";
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
