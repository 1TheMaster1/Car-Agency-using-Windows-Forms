using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Hossam
{//class for car services available to customers
    internal class CarService
    {
        int chargePerHour = 10;

        public double Maintenance(int hours)
        {
            return chargePerHour * hours * 0.8;
        }
        public double Paint(int hours)
        {
            return chargePerHour * hours;
        }
    }
}
