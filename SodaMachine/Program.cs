﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //SodaMachine test = new SodaMachine();
            //test.AddStarterCoinsToMachine();

            Customer test = new Customer();
            test.TotalAmountToSpend();
            
            
            Console.ReadKey();


        }
    }
}
