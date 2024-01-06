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
        Sales? salaryEmployee;
        protected CommissionedSales? commissionedSalesEmployee;
        Technician? technicianEmployee;
        Management? managementEmployee;
        Finance? financeEmployee;

        public Invoice(int payment, Employee employee)
        {
            this.payment = payment;
            if (employee is Sales)
                salaryEmployee = (Sales)employee;
            if (employee is CommissionedSales)
                commissionedSalesEmployee = (CommissionedSales)employee;
            if (employee is Technician)
                technicianEmployee = (Technician)employee;
            if (employee is Management)
                managementEmployee = (Management)employee;
            if (employee is Finance)
                financeEmployee = (Finance)employee;
        }
        public Invoice() { }
    }
}
