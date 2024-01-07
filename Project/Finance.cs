using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Yamen
{//inherits from Employee 
    internal class Finance : Employee
    {
        public Finance(string name, int age, int salary, string password)
           : base(name, age, salary, "finance", password) { }
        public Finance(int id, string name, int age, int salary)
            :base(id, name, age, salary, "finance") { }

        public override int GetSalary()
        {
            return Salary;
        }
    }
}
