using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("You can't enter a negative value\nPlease try again") { }
    }
}
