using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for employees
    internal class SalaryInvoice : Invoice
    {
        Sales? salaryEmployee;
        CommissionedSales? commissionedSalesEmployee;
        Technician? technicianEmployee;
        Management? managementEmployee;
        Finance? financeEmployee;
        public static List<SalaryInvoice> salaryInvoiceList = new List<SalaryInvoice>();

        public SalaryInvoice(int payment, Employee employee) 
        {
            Payment = payment;
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
    }
}
