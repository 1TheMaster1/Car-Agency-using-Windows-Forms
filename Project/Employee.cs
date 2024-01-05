using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project //Yamen
{//base class for all employees
    public class Employee
    {
        string? id;
        string? name;
        int age;
        int salary;
        static int count = 1000; //for creating IDs
        string? authority;
        string? password;
        public static List<Employee> employeeList = new List<Employee>();

        public Employee(string name, int age, int salary, string authority, string password)
        {
            id = count.ToString("0000");
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.authority = authority;
            this.password = password;
            count = count + 1;
        }
        public Employee(string name, int age, int salary, string authority) 
        {
            id = count.ToString("0000");
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.authority = authority;
            password = id;
            count = count + 1;
        }
        public Employee(string name)
        {
            id = "0000";
            this.name = name;
            age = 0;
            salary = 0;
            authority = "management";
            password = "admin";
        }
        public Employee() { }

        public string? Name { get { return name; } }
        public string? Authority {  get { return authority; } }
        public string? Password { get { return password; } }
        public int Salary { get { return salary; } }

        public virtual int GetSalary() { return salary; }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}", id, name, age, salary, authority);
        }
    }
}
