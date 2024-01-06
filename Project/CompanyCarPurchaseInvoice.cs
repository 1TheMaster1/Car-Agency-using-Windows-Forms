using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//inherits from Invoice and made for company car purchases
    internal class CompanyCarPurchaseInvoice : Invoice
    {
        int amount;
        Car? car; 
        public static List<CompanyCarPurchaseInvoice> companyCarPurchaseInvoiceList = new List<CompanyCarPurchaseInvoice>();

        public CompanyCarPurchaseInvoice(int payment, Employee employee, int amount, Car car)
            : base(payment, employee)
        {
            this.amount = amount;
            this.car = car;
        }
    }
}
