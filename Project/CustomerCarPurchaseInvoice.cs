using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for customer car purchase
    internal class CustomerCarPurchaseInvoice : Invoice
    {
        int amount;
        Car? car;
        Customer? customer;
        public static List<CustomerCarPurchaseInvoice> customerCarPurchaseInvoiceList = new List<CustomerCarPurchaseInvoice>();

        public CustomerCarPurchaseInvoice(int payment, Employee employee, int amount, Customer customer, Car car) 
            : base(payment, employee)
        {
            this.amount = amount;
            this.car = car;
            this.customer = customer;
            if (employee is CommissionedSales)
                commissionedSalesEmployee.NumberOfSales ++;
        }
    }
}
