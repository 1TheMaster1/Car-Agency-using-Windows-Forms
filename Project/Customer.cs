using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project //Yamen
{//class for customers the company deals with
    public class Customer
    {
        string id;
        string name;
        int age;
        static int count = 2001; //for creating IDs
        string phoneNumber;
        int numberOfPurchase;
        int totalPayment;
        public static List<Customer> customerList = new List<Customer>();
        public Customer(string name, int age, string phoneNumber) 
        {
            id = count.ToString("0000");
            this.name = name;
            this.age = age;
            this.phoneNumber = phoneNumber;
            numberOfPurchase = 0;
            totalPayment = 0;
        }

        public void Purchase(int payment) //To update database with customer purchase
        {
            //insert an update to the file here
            totalPayment += payment;
            numberOfPurchase++;
        }

        public void Service(int payment) //To update database with customer paid service
        {
            //insert an update to the file here
            totalPayment += payment;
        }

        public int Discount() //To calculate if the customer has a discount
        {
            if (numberOfPurchase > 5 && totalPayment > 500*10e3)
                return numberOfPurchase;//insert a formula for discount here
            else 
                return 0;
        }
        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", id, name, age, phoneNumber, numberOfPurchase, totalPayment);
        }
    }
}
