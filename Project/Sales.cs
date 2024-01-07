using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Yamen
{//inherits from Employee and has access only to Inventory
    internal class Sales : Employee
    {
        public Sales(string name, int age, int salary, string password)
            : base(name, age, salary, "sales", password) { }
        public Sales(int id, string name, int age, int salary)
            : base(id, name, age, salary, "sales") { }

        public override int GetSalary()
        {
            return Salary;
        }  
    }
}
