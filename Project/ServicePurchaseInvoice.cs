using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for customer service purchase
    internal class ServicePurchaseInvoice : Invoice
    {
        int hours;
        Customer? customer;
        public static List<ServicePurchaseInvoice> servicePurchaseInvoiceList = new List<ServicePurchaseInvoice>();

        public ServicePurchaseInvoice(int payment, int hours, Employee employee, Customer customer) 
            : base(payment, employee)
        {
            this.hours = hours;
            this.customer = customer;
        }
    }
}
