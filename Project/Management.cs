using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Yamen
{//inherits from Employee and 
    internal class Management : Employee
    {
        public Management(string name, int age, int salary, string password)
            : base(name, age, salary, "management", password) { }
        public Management(string name, int age, int salary)
            : base(name, age, salary, "management") { }

        public override int GetSalary()
        {
            return Salary;
        }   
    }
}
