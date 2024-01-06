using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//base class for all Invoices
    internal class Invoice
    {
        int payment;
        Employee? employee;

        public Invoice(int payment, Employee employee)
        {
            this.payment = payment;
            this.employee = employee;
        }
        public Invoice() { }

        public int Payment { get { return payment; } }
    }
}
