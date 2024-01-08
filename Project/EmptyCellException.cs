using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class EmptyCellException: Exception
    {
        public EmptyCellException(): base("There's an empty field\nPlease try again") {  }
    }
}
