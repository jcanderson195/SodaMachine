using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Quarter : Coin
    {

        public double quarterValue;

        public Quarter(double QuarterValue)
        {
            quarterValue = QuarterValue;   //.25
        }

        

    }
}
