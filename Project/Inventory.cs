using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//class to access stock and update it
    public class Inventory
    {
        string? id;
        Car car = new Car();
        int quantity;
        static int count = 0;
        public static List<Inventory> inventoryList = new List<Inventory>();

        public Inventory(Car car, int quantity)
        {
            id = count.ToString();
            this.car = car;
            this.quantity = quantity;
            count = count + 1;
        }
        public Inventory() { }

        public string? ID {  get { return id; } }
        public Car Car { get { return car; } }
        public int Quantity { get { return quantity; } set { if (value >= 0) quantity = value; } }
    }
}
