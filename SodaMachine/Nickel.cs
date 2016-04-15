using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Nickel : Coin
    {

        public double nickelValue;

        public Nickel(double NickelValue)
        {
            nickelValue = NickelValue;      //.05
        }

    }
}
