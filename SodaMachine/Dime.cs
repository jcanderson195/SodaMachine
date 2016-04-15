using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Dime : Coin
    {

        public double dimeValue;

        public Dime(double DimeValue)
        {
            dimeValue = DimeValue;      //.10
        }
    }
}
