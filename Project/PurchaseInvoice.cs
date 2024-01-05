using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for customers
    internal class PurchaseInvoice : Invoice
    {
        Customer? customer;
        Sales? salaryEmployee;
        CommissionedSales? commissionedSalesEmployee;
        Technician? technicianEmployee;
        Management? managementEmployee;
        public static List<PurchaseInvoice> purchaseInvoiceList = new List<PurchaseInvoice>();

        public PurchaseInvoice(int payment,Customer customer, Employee employee)
        {
            Payment = payment;
            this.customer = customer;
            if (employee is Sales)
                salaryEmployee = (Sales) employee;
            if (employee is CommissionedSales)
            {
                commissionedSalesEmployee = (CommissionedSales)employee;
                commissionedSalesEmployee.NumberOfSales ++;
            }   
            if (employee is Technician)
                technicianEmployee = (Technician) employee;
            if (employee is Management)
                managementEmployee = (Management) employee;
        }
    }
}
