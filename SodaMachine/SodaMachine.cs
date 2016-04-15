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

        List<Soda> SodaInventory;
        public SodaMachine()
        {
            MachineRegister = new List<Coin>();

            SodaInventory = new List<Soda>();
        }

        public void Greeting()
        {
            AddStarterCoinsToMachine();
            AddStarterSodasToMachine();
            Console.WriteLine("Welcome to DevCodeCamp Soda Dispenser");
            Console.WriteLine("----------------------");

        }

        public void AddStarterCoinsToMachine()
        {
            
           for (int i = 0; i < 50; i++)
            {
                
                MachineRegister.Add(new Penny(.01));  
            }

                
            for (int i = 0; i < 20; i++)
            {
                MachineRegister.Add(new Nickel(.05));
            }

                

            for (int i = 0; i < 10; i++)
            {
                MachineRegister.Add(new Dime(.10));
            }

                

            for (int i = 0; i < 25; i++)
            {
                MachineRegister.Add(new Quarter(.25));
            }

                
        }       //good


        

        public void AddStarterSodasToMachine()
        {
            for (int i = 0; i < 6; i++)
            {

                SodaInventory.Add(new Soda("Grape",.60));
                SodaInventory.Add(new Soda("Orange", .35));

            }

            for (int i = 0; i < 4; i++)
            {
                SodaInventory.Add(new Soda("Meat", .06));
            }
        }       //good

//public void DisplayCoinsInMachineRegister()
        //{
        //    foreach (Coin coin in MachineRegister)
        //    {
        //        //if (Coin == penny)

        //        //Console.WriteLine("penny");
        //    }

        //    foreach (Nickel nickel in MachineRegister)
        //    {
        //        Console.WriteLine("nickel");
        //    }

        //    foreach (Dime dime in MachineRegister)
        //    {
        //        Console.WriteLine("dime");
        //    }

        //    foreach (Quarter quarter in MachineRegister)
        //    {
        //        Console.WriteLine("quarter");
        //    }
        //}


    }

}
