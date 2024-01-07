using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Xml.Linq;

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
            SqlCommand cmd = new SqlCommand("select * from Employees", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("empID"));
                string name = reader.GetString(reader.GetOrdinal("empName"));
                int age = reader.GetInt32(reader.GetOrdinal("empAge"));
                int salary = reader.GetInt32(reader.GetOrdinal("empSalary"));
                string role = reader.GetString(reader.GetOrdinal("empRole"));
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
            MessageBox.Show("Gamed Gamed");

            //Bitmap image1 = new Bitmap("E:\\Cars\\Hammer.jpg");
            //Bitmap image2 = new Bitmap("E:\\Programming Project\\Files\\Cars\\Ferrari.jpg");
            //Car car1 = new Car("Hammer","a","yellow",100,"4x4",1000,2000,image1);
            //Car car2 = new Car("Ferrari","b","red",200,"sports",2000,4000,image2);
            //Inventory inventory1 = new Inventory(car1,200);
            //Inventory inventory2 = new Inventory(car2,100);
            //Inventory.inventoryList.Add(inventory1);
            //Inventory.inventoryList.Add(inventory2);

            ApplicationConfiguration.Initialize();
            Application.Run(new StartWindow());
            //Application.Run(new SellCarForm(deafultUser, car1));
        }
    }
}