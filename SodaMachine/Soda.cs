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
        public int amountAvailable;

        public Soda(string SodaFlavor, double SodaPrice, int AmountAvailable)
        {
            sodaFlavor = SodaFlavor;
            sodaPrice = SodaPrice;
            amountAvailable = AmountAvailable;

        }

        public Soda()
        {
            sodaFlavor = null;
        }
    }
}
