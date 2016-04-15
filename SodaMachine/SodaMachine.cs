using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        List<Coin> MachineRegister;
        

        public SodaMachine()
        {
            MachineRegister = new List<Coin>();

            
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome to DevCodeCamp Soda Dispenser");
            Console.WriteLine("----------------------");

        }

        public void AddStarterCoinsToMachine()
        {
            
           for (int i = 0; i < 51; i++)
            {
                
                MachineRegister.Add(new Penny(.01));
            }

           for (int i = 0; i < 21; i++)
            {
                MachineRegister.Add(new Nickel(.05));
            }

            for (int i = 0; i < 11; i++)
            {
                MachineRegister.Add(new Dime(.10));
            }

            for (int i = 0; i < 26; i++)
            {
                MachineRegister.Add(new Quarter(.25));
            }
        }

        


    }
}
