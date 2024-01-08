using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Diagnostics;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Employee deafultUser = new Employee("admin");
            Employee.employeeList.Add(deafultUser);

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Employees", cnn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                int id = reader1.GetInt32(reader1.GetOrdinal("empID"));
                string name = reader1.GetString(reader1.GetOrdinal("empName"));
                int age = reader1.GetInt32(reader1.GetOrdinal("empAge"));
                int salary = reader1.GetInt32(reader1.GetOrdinal("empSalary"));
                string role = reader1.GetString(reader1.GetOrdinal("empRole"));
                Employee employee = new Employee();
                if (role == "management")
                    employee = new Employee(id, name, age, salary, role);
                if (role == "finance")
                    employee = new Employee(id, name, age, salary, role);
                if (role == "sales")
                    employee = new Employee(id, name, age, salary, role);
                if (role == "technician")
                    employee = new Employee(id, name, age, salary, role);
                Employee.employeeList.Add(employee);
            }
            cnn.Close();
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Customers", cnn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                int id = reader2.GetInt32(reader2.GetOrdinal("customerID"));
                string name = reader2.GetString(reader2.GetOrdinal("customerName"));
                int age = reader2.GetInt32(reader2.GetOrdinal("customerAge"));
                string phone = reader2.GetString(reader2.GetOrdinal("customerPhone"));
                int NOP = reader2.GetInt32(reader2.GetOrdinal("customerNOP"));
                int TP = reader2.GetInt32(reader2.GetOrdinal("customerTP"));
                Customer customer = new Customer(id, name, age, phone, NOP, TP);
                Customer.customerList.Add(customer);
            }
            cnn.Close();
            cnn.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Cars", cnn);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                int id = reader3.GetInt32(reader3.GetOrdinal("carID"));
                string model = reader3.GetString(reader3.GetOrdinal("carModel"));
                string make = reader3.GetString(reader3.GetOrdinal("carMake"));
                string color = reader3.GetString(reader3.GetOrdinal("carColor"));
                int hp = reader3.GetInt32(reader3.GetOrdinal("carHP"));
                string type = reader3.GetString(reader3.GetOrdinal("carType"));
                int pp = reader3.GetInt32(reader3.GetOrdinal("carPP"));
                int sp = reader3.GetInt32(reader3.GetOrdinal("carSP"));
                string image = reader3.GetString(reader3.GetOrdinal("carImage"));
                int stock = reader3.GetInt32(reader3.GetOrdinal("carStock"));
                Bitmap? carImage = null;
                Car? car = null;
                Inventory? inventory = null;
                if (image != null)
                {
                    carImage = new Bitmap(image);
                    car = new Car(id, model, make, color, hp, type, pp, sp, carImage);
                    Car.carList.Add(car);
                    inventory = new Inventory(id, car, stock);
                    Inventory.inventoryList.Add(inventory);
                }                    
            }
            cnn.Close();
            cnn.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Invoices", cnn);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                int invoiceCustomerID = reader4.GetInt32(reader4.GetOrdinal("invoiceID"));
                int empID = reader4.GetInt32(reader4.GetOrdinal("empID"));
                int customerID = reader4.GetInt32(reader4.GetOrdinal("customerID"));
                int carID = reader4.GetInt32(reader4.GetOrdinal("carID"));
                int invoiceTP = reader4.GetInt32(reader4.GetOrdinal("invoiceTP"));
                string invoiceType = reader4.GetString(reader4.GetOrdinal("invoiceType"));
                Employee emp = Employee.employeeList[empID];
                Customer cust = Customer.customerList[customerID - 1];
                Car car = Car.carList[carID -  1];
                if (invoiceType == "purchase")
                {
                    CustomerCarPurchaseInvoice purchase = new CustomerCarPurchaseInvoice(invoiceCustomerID, invoiceTP, emp, cust, car); 
                    CustomerCarPurchaseInvoice.customerCarPurchaseInvoiceList.Add(purchase);
                }
                if (invoiceType == "service")
                {
                    ServicePurchaseInvoice purchase = new ServicePurchaseInvoice(invoiceCustomerID, invoiceTP, emp, cust);
                    ServicePurchaseInvoice.servicePurchaseInvoiceList.Add(purchase);
                }
            }
            cnn.Close();
            

            ApplicationConfiguration.Initialize();
            Application.Run(new StartWindow());

        }
    }
}