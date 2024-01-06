using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for employees
    internal class SalaryInvoice : Invoice
    {
        public static List<SalaryInvoice> salaryInvoiceList = new List<SalaryInvoice>();

        public SalaryInvoice(int payment, Employee employee) : base(payment, employee) { }
    }
}
