using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Soda
    {

        public string sodaFlavor;
        public double sodaPrice;

        public Soda(string SodaFlavor, double SodaPrice)
        {
            sodaFlavor = SodaFlavor;
            sodaPrice = SodaPrice;

        }

        public Soda()
        {
            sodaFlavor = null;
        }
    }
}
