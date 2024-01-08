using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for customer car purchase
    internal class CustomerCarPurchaseInvoice : Invoice
    {
        int id;
        Car? car;
        Customer? customer;
        public static List<CustomerCarPurchaseInvoice> customerCarPurchaseInvoiceList = new List<CustomerCarPurchaseInvoice>();

        public CustomerCarPurchaseInvoice(int id, int payment, Employee employee, Customer customer, Car car) 
            : base(payment, employee)
        {
            this.id = id;
            this.car = car;
            this.customer = customer;
        }
    }
}
