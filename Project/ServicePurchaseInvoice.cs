using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for customer service purchase
    internal class ServicePurchaseInvoice : Invoice
    {
        public static int payment = 0;               //random
        int id;
        Customer? customer;
        public static List<ServicePurchaseInvoice> servicePurchaseInvoiceList = new List<ServicePurchaseInvoice>();

        public ServicePurchaseInvoice(int id, int payment, Employee employee, Customer customer) 
            : base(payment, employee)
        {
            this.id = id;
            this.customer = customer;
        }
    }
}
