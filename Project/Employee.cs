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
        int id;
        string? name;
        int age;
        int salary;
        string? role;
        string? password;
        public static List<Employee> employeeList = new List<Employee>();

        public Employee(string name, int age, int salary, string role, string password)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.role = role;
            this.password = password;
        }
        public Employee(int id, string name, int age, int salary, string role) 
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.role = role;
            password = id.ToString();
        }
        public Employee(string name)
        {
            id = 0;
            this.name = name;
            age = 0;
            salary = 0;
            role = "management";
            password = "admin";
        }
        public Employee() { }

        public int ID { get { return id; } }
        public string? Name { get { return name; } }
        public string? Role {  get { return role; } }
        public string? Password { get { return password; } }
        public int Salary { get { return salary; } }

        public virtual int GetSalary() { return salary; }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}", id, name, age, salary, role);
        }
    }
}
