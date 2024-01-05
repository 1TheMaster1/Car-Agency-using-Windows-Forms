using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Yamen
{//inherits from Employee and has access only to CarService
    internal class Technician : Employee
    {
        public Technician(string name, int age, int salary, string password)
            : base(name, age, salary, "technician", password) { }
        public Technician(string name, int age, int salary)
            : base(name, age, salary, "technician") { }

        public override int GetSalary()
        {
            return Salary;
        }
    }
}
