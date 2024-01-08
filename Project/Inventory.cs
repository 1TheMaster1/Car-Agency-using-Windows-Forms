using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Omar
{//class to access stock and update it
    public class Inventory
    {
        int id;
        Car car = new Car();
        int quantity;
        public static List<Inventory> inventoryList = new List<Inventory>();

        public Inventory(int id, Car car, int quantity)
        {
            this.id = id;             
            this.car = car;
            this.quantity = quantity;
        }
        public Inventory() { }

        public int ID {  get { return id; } }
        public Car Car { get { return car; } }
        public int Quantity { get { return quantity; } set { if (value >= 0) quantity = value; } }
    }
}
