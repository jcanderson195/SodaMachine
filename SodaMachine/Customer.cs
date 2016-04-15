using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        private double walletBalance;

        //Quarter quarter;
        //Dime dime;
        //Nickel nickel;
        //Penny penny;

        public int quarterAmount;
        public int dimeAmount;
        public int nickelAmount;
        public int pennyAmount;

        public double quarterAmountValue;
        public double dimeAmountValue;
        public double nickelAmountValue;
        public double pennyAmountValue;

        List<Coin> CoinsOwned;

        public Customer()
        {
            CoinsOwned = new List<Coin>();
        }

        public double WalletBalance
        {
            get
            {
                return walletBalance;
            }

            set
            {
                walletBalance = value;
            }
        }

        public void EnterQuarterAmount()
        {
            Console.WriteLine("How many quarters do you have to spend today? ");
            Console.WriteLine("----------------------");
            quarterAmount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quarterAmount; i++)
            {
                CoinsOwned.Add(new Quarter(.25));
            }
            quarterAmountValue = quarterAmount * .25;
            Console.WriteLine("----------------------");
            Console.WriteLine("You have " + quarterAmountValue + " in quarters.");
            Console.WriteLine("----------------------");
        }

        public void EnterDimeAmount()
        {
            Console.WriteLine("How many dimes do you have to spend today? ");
            Console.WriteLine("----------------------");
            dimeAmount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dimeAmount; i++)
            {
                CoinsOwned.Add(new Dime(.10));
            }
            dimeAmountValue = dimeAmount * .10;
            Console.WriteLine("----------------------");
            Console.WriteLine("You have " + dimeAmountValue + " in dimes.");
            Console.WriteLine("----------------------");
        }

        public void EnterNickelAmount()
        {
            Console.WriteLine("How many nickels do you have to spend today? ");
            Console.WriteLine("----------------------");
            nickelAmount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nickelAmount; i++)
            {
                CoinsOwned.Add(new Nickel(.05));
            }
            nickelAmountValue = nickelAmount * .05;
            Console.WriteLine("----------------------");
            Console.WriteLine("You have " + nickelAmountValue + " in nickels.");
            Console.WriteLine("----------------------");
        }

        public void EnterPennyAmount()
        {
            Console.WriteLine("How many pennies do you have to spend today? ");
            Console.WriteLine("----------------------");
            pennyAmount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < pennyAmount; i++)
            {
                CoinsOwned.Add(new Penny(.01));
            }
            pennyAmountValue = pennyAmount * .01;
            Console.WriteLine("----------------------");
            Console.WriteLine("You have " + pennyAmountValue + " in pennies.");
            Console.WriteLine("----------------------");
        }

        public void TotalAmountToSpend()
        {
            EnterQuarterAmount();
            EnterDimeAmount();
            EnterNickelAmount();
            EnterPennyAmount();

            walletBalance = quarterAmountValue + dimeAmountValue + nickelAmountValue + pennyAmountValue;
            Console.WriteLine("You have "+walletBalance+" dollars to spend today.");
        }
    }
}
