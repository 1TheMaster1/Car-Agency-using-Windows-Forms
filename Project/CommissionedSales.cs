using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Yamen
{//inherits from Sales and has same access but paid in commission too
    internal class CommissionedSales : Sales
    {
        int commission;
        int numberOfSales = 0;

        public CommissionedSales(string name, int age, int salary, string password)
            : base(name, age, salary, password)
        {
            commission = 100;
        }
        public CommissionedSales(int id, string name, int age, int salary)
            : base(id, name, age, salary) 
        { 
            commission = 100;
        }

        public int NumberOfSales {  get { return numberOfSales; } set { if (value >= 0) numberOfSales = value; } }

        public override int GetSalary()
        {
            return Salary + commission * numberOfSales;
        }
    }
}
