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
            Employee employee = new Employee("hossam",0,0,"sales","11111111111111");//test employee
            Employee.employeeList.Add(employee);
            //Bitmap image1 = new Bitmap("E:\\Programming Project\\Files\\Cars\\Hammer.jpg");
            //Bitmap image2 = new Bitmap("E:\\Programming Project\\Files\\Cars\\Ferrari.jpg");
            //Car car1 = new Car("Hammer","a","yellow",100,"4x4",1000,2000,image1);
            //Car car2 = new Car("Ferrari","b","red",200,"sports",2000,4000,image2);
            //Inventory inventory1 = new Inventory(car1,200);
            //Inventory inventory2 = new Inventory(car2,100);
            //Inventory.inventoryList.Add(inventory1);
            //Inventory.inventoryList.Add(inventory2);

            ApplicationConfiguration.Initialize();
            Application.Run(new StartWindow());
            //Application.Run(new InventoryForm(deafultUser));
        }
    }
}