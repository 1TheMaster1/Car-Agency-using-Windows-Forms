using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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
            try
            {   if(Convert.ToInt32(ageTextBox.Text) <= 0 || Convert.ToInt32(salaryTextBox.Text) <= 0)
                    throw new NegativeNumberException();
                foreach (Control c in employeeGroupBox.Controls)
                {
                    if (c is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                        if (textBox != null)
                            if (textBox.Text == string.Empty)
                            {
                                throw new EmptyCellException();
                            }
                    }
                }
                int id = 0;
                int x = jobComboBox.SelectedIndex;
                string name = nameTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                int salary = Convert.ToInt32(salaryTextBox.Text);
                string? role = null;

                switch (x)
                {
                    case 0:
                        role = "management"; break;
                    case 1:
                        role = "sales"; break;
                    case 2:
                        role = "sales"; break;
                    case 3:
                        role = "finance"; break;
                    case 4:
                        role = "technician"; break;
                    default:
                        MessageBox.Show("Choose a job"); break;
                }

                string connectionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
                string tableName = "Employees";
                string primaryKeyColumnName = "empID";
                int maxPrimaryKey = GetMaxPrimaryKeyValue(connectionString, tableName, primaryKeyColumnName);
                if (role != null)
                    InsertNewRecordEmployee(id, x, name, age, salary, role, connectionString, tableName, primaryKeyColumnName, maxPrimaryKey + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            int id = Employee.employeeList[x - 1].ID;
            if (x > -1)
            {
                Employee.employeeList.RemoveAt(x - 1);
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Delete Employees where empID=@empID", cnn);
                cmd.Parameters.AddWithValue("@empID", id);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Successfully Deleted");
            }
            else
                MessageBox.Show("Select an item");

            updateEmployeeButton_Click(sender, e);
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(customerAgeTextBox.Text) <= 0)
                    throw new NegativeNumberException();
                foreach (Control c in customerGroupBox.Controls)
                {
                    if (c is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                        if (textBox != null)
                            if (textBox.Text == string.Empty)
                            {
                                throw new EmptyCellException();
                            }
                    }
                }
                string name = customerNameTextBox.Text;
                int age = Convert.ToInt32(customerAgeTextBox.Text);
                string phone = customerNumberTextBox.Text;

                string connectionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
                string tableName = "Customers";
                string primaryKeyColumnName = "customerID";
                int maxPrimaryKey = GetMaxPrimaryKeyValue(connectionString, tableName, primaryKeyColumnName);
                InsertNewRecordCustomer(name, age, phone, connectionString, tableName, primaryKeyColumnName, maxPrimaryKey + 1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
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
            {
                int id = Customer.customerList[x - 2].ID;
                Customer.customerList.RemoveAt(x - 2);

                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Delete Customers where customerID=@customerID", cnn);
                cmd.Parameters.AddWithValue("@customerID", id);
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Successfully Deleted");
            }
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
        static void InsertNewRecordEmployee(int id, int x, string name, int age, int salary, string role, string connectionString, string tableName, string primaryKeyColumnName, int newPrimaryKeyValue)
        {
            Employee employee = new Employee();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO {tableName} ({primaryKeyColumnName}, ...) VALUES ({newPrimaryKeyValue}, ...)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (role != null)
                    {
                        string connetionString;
                        SqlConnection cnn;
                        connetionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
                        cnn = new SqlConnection(connetionString);
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand("insert into Employees values (@empID,@empName,@empAge,@empSalary,@empRole)", cnn);
                        cmd.Parameters.AddWithValue("@empID", newPrimaryKeyValue);
                        cmd.Parameters.AddWithValue("@empName", name);
                        cmd.Parameters.AddWithValue("@empAge", age);
                        cmd.Parameters.AddWithValue("@empSalary", salary);
                        cmd.Parameters.AddWithValue("@empRole", role);
                        cmd.ExecuteNonQuery();
                        string querynew = "SELECT TOP 1 * FROM Employees ORDER BY empID DESC";
                        SqlCommand cmdNew = new SqlCommand(querynew, cnn);
                        SqlDataReader reader = cmdNew.ExecuteReader();
                        while (reader.Read())
                        {
                            id = reader.GetInt32(reader.GetOrdinal("empID"));
                        }
                        cnn.Close();
                        if (id != 0)
                        {
                            switch (x)
                            {
                                case 0:
                                    employee = new Management(id, name, age, salary);
                                    Employee.employeeList.Add(employee);
                                    MessageBox.Show("Added new \"management\"");
                                    break;
                                case 1:
                                    employee = new Sales(id, name, age, salary);
                                    Employee.employeeList.Add(employee);
                                    MessageBox.Show("Added new \"sales\"");
                                    break;
                                case 2:
                                    employee = new CommissionedSales(id, name, age, salary);
                                    Employee.employeeList.Add(employee);
                                    MessageBox.Show("Added new \"commissioned sales\"");
                                    break;
                                case 3:
                                    employee = new Finance(id, name, age, salary);
                                    Employee.employeeList.Add(employee);
                                    MessageBox.Show("Added new \"finance\"");
                                    break;
                                case 4:
                                    employee = new Technician(id, name, age, salary);
                                    Employee.employeeList.Add(employee);
                                    MessageBox.Show("Added new \"technician\"");
                                    break;
                                default:
                                    MessageBox.Show("Choose a job"); break;
                            }
                        }
                    }
                }
            }
        }

        static void InsertNewRecordCustomer(string name,int age,string phone,string connectionString, string tableName, string primaryKeyColumnName, int newPrimaryKeyValue)
        {
            int id = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO {tableName} ({primaryKeyColumnName}, ...) VALUES ({newPrimaryKeyValue}, ...)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlCommand cmd = new SqlCommand("insert into Customers values (@customerID,@customerName,@customerAge,@customerPhone,@customerNOP, @customerTP)", connection);
                    cmd.Parameters.AddWithValue("@customerID", newPrimaryKeyValue);
                    cmd.Parameters.AddWithValue("@customerName", name);
                    cmd.Parameters.AddWithValue("@customerAge", age);
                    cmd.Parameters.AddWithValue("@customerPhone", phone);
                    cmd.Parameters.AddWithValue("@customerTP", 0);
                    cmd.Parameters.AddWithValue("@customerNOP", 0);
                    cmd.ExecuteNonQuery();
                    string querynew = "SELECT TOP 1 * FROM Customers ORDER BY customerID DESC";
                    SqlCommand cmdNew = new SqlCommand(querynew,connection);
                    SqlDataReader reader = cmdNew.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(reader.GetOrdinal("customerID"));
                    }
                }
            }
            Customer customer = new Customer(id, name, age, phone);
            Customer.customerList.Add(customer);
            MessageBox.Show("Added new \"customer\"");
        }
    }
}
