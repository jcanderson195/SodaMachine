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

        List<Soda> CustomerOwnedSoda;

        Customer customer;

        private double machineRegisterBalance;

        public string choice;


        public Soda grape;
        public Soda orange;
        public Soda meat;

        public Quarter quarter;
        public Dime dime;
        public Nickel nickel;
        public Penny penny;

        public double MachineRegisterBalance
        {
            get
            {
                return machineRegisterBalance;
            }

            set
            {
                machineRegisterBalance = value;
            }
        }

        public SodaMachine()
        {
            MachineRegister = new List<Coin>();

            SodaInventory = new List<Soda>();

            customer = new Customer();

            CustomerOwnedSoda = new List<Soda>();

            machineRegisterBalance = 7.50;


        }

        public void Greeting()
        {
            AddStarterCoinsToMachine();
            AddStarterSodasToMachine();
            Console.WriteLine("Welcome to DevCodeCamp Soda Dispenser");
            Console.WriteLine("----------------------");
            DisplaySodasInMachine();
            Console.WriteLine("----------------------");
            customer.TotalAmountToSpend();
            OperationsMenu();

        }



        public void OperationsMenu()
        {
            

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please enter what flavor of soda you would like to buy? Grape, Orange, or Meat. Flavor names are case sensitive.");
            Console.WriteLine("--------------------------------");
            choice = Console.ReadLine();

            if (machineRegisterBalance < .60)
            {
                NoSufficientChangeInRegister();
            }
            else if (choice == "Grape" && customer.WalletBalance == .60)
            {
                ExactPayment();
                DisplaySodasInMachine();
                Console.WriteLine("---------------");
                Console.WriteLine("Have a good day!");
                OperationsMenu();
            }
            else if (choice == "Grape" && customer.WalletBalance < .60)
            {
                NoSufficientChangeInRegister();
                NotEnoughMoney();
                DisplaySodasInMachine();
                OperationsMenu();
            }
            else if (choice == "Grape" && customer.WalletBalance > .60)
            {
                NoSufficientChangeInRegister();
                TooMuchMoney();
                DisplaySodasInMachine();
                Console.WriteLine("---------------");
                Console.WriteLine("Have a good day!");
                OperationsMenu();
            }

            else if (choice == "Orange" && customer.WalletBalance == .35)
            {
                ExactPayment();
                DisplaySodasInMachine();
                Console.WriteLine("---------------");
                Console.WriteLine("Have a good day!");
                OperationsMenu();
            }
            else if (choice == "Orange" && customer.WalletBalance < .60)
            {
                NotEnoughMoney();
                DisplaySodasInMachine();
                OperationsMenu();
            }
            else if (choice == "Orange" && customer.WalletBalance > .60)
            {
                NoSufficientChangeInRegister();
                TooMuchMoney();
                DisplaySodasInMachine();
                Console.WriteLine("---------------");
                Console.WriteLine("Have a good day!");
                OperationsMenu();
            }
            else if (choice == "Meat" && customer.WalletBalance == .06)
            {
                NoSufficientChangeInRegister();
                ExactPayment();
                DisplaySodasInMachine();
                Console.WriteLine("---------------");
                Console.WriteLine("Have a good day!");
                OperationsMenu();
            }
            else if (choice == "Meat" && customer.WalletBalance < .06)
            {
                NotEnoughMoney();
                DisplaySodasInMachine();
                OperationsMenu();
            }
            else if (choice == "Meat" && customer.WalletBalance > .06)
            {
                TooMuchMoney();
                DisplaySodasInMachine();
                Console.WriteLine("---------------");
                Console.WriteLine("Have a good day!");
                OperationsMenu();
            }

            //NoSufficientChangeInRegister();
            //NoSufficientSodaInventory();
        }


        public void AddStarterCoinsToMachine()
        {

            for (int i = 0; i < 50; i++)
            {

                penny = new Penny(.01);
                MachineRegister.Add(penny);
            }


            for (int i = 0; i < 20; i++)
            {
                nickel = new Nickel(.05);
                MachineRegister.Add(nickel);
            }



            for (int i = 0; i < 10; i++)
            {
                dime = new Dime(.10);
                MachineRegister.Add(dime);
            }



            for (int i = 0; i < 25; i++)
            {
                quarter = new Quarter(.25);
                MachineRegister.Add(quarter);
            }


        }       //good




        public void AddStarterSodasToMachine()
        {

            grape = new Soda("Grape", .60, 5);
            SodaInventory.Add(grape);

            orange = new Soda("Orange", .35, 5);
            SodaInventory.Add(orange);

            meat = new Soda("Meat", .06, 4);
            SodaInventory.Add(meat);

        }       //good


        public void DisplaySodasInMachine()
        {
            foreach (Soda soda in SodaInventory)
            {
                Console.WriteLine("Soda Flavor: " + soda.sodaFlavor + "| Price: " + soda.sodaPrice + "|Amount available: " + soda.amountAvailable);
            }
        }           //good

        public void NotEnoughMoney()
        {
            //If not enough money is passed in, don't complete transaction: give the money back


            if (choice == "Grape")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");
                if (customer.WalletBalance < .60)
                {
                    customer.CoinsOwned.Remove(quarter);
                    customer.CoinsOwned.Remove(quarter);
                    customer.CoinsOwned.Remove(nickel);
                    customer.CoinsOwned.Remove(penny);
                    customer.CoinsOwned.Remove(penny);
                    customer.CoinsOwned.Remove(penny);
                    customer.CoinsOwned.Remove(penny);


                    MachineRegister.Add(quarter);
                    MachineRegister.Add(quarter);
                    MachineRegister.Add(nickel);
                    MachineRegister.Add(penny);
                    MachineRegister.Add(penny);
                    MachineRegister.Add(penny);
                    MachineRegister.Add(penny);

                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Insufficient funds. Returning money.");
                    Console.WriteLine("-----------------------------");

                    MachineRegister.Remove(quarter);
                    MachineRegister.Remove(quarter);
                    MachineRegister.Remove(nickel);
                    MachineRegister.Remove(penny);
                    MachineRegister.Remove(penny);
                    MachineRegister.Remove(penny);
                    MachineRegister.Remove(penny);

                    customer.CoinsOwned.Add(quarter);
                    customer.CoinsOwned.Add(quarter);
                    customer.CoinsOwned.Add(nickel);
                    customer.CoinsOwned.Add(penny);
                    customer.CoinsOwned.Add(penny);
                    customer.CoinsOwned.Add(penny);
                    customer.CoinsOwned.Add(penny);
                }
            }
            else if (choice == "Orange")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");
                if (customer.WalletBalance < .35)
                {
                    customer.CoinsOwned.Remove(quarter);
                    customer.CoinsOwned.Remove(nickel);
                    customer.CoinsOwned.Remove(penny);
                    customer.CoinsOwned.Remove(penny);
                    customer.CoinsOwned.Remove(penny);
                    customer.CoinsOwned.Remove(penny);


                    MachineRegister.Add(quarter);
                    MachineRegister.Add(nickel);
                    MachineRegister.Add(penny);
                    MachineRegister.Add(penny);
                    MachineRegister.Add(penny);
                    MachineRegister.Add(penny);

                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Insufficient funds. Returning money.");
                    Console.WriteLine("-----------------------------");

                    MachineRegister.Remove(quarter);
                    MachineRegister.Remove(nickel);
                    MachineRegister.Remove(penny);
                    MachineRegister.Remove(penny);
                    MachineRegister.Remove(penny);
                    MachineRegister.Remove(penny);

                    customer.CoinsOwned.Add(quarter);
                    customer.CoinsOwned.Add(nickel);
                    customer.CoinsOwned.Add(penny);
                    customer.CoinsOwned.Add(penny);
                    customer.CoinsOwned.Add(penny);
                    customer.CoinsOwned.Add(penny);
                }
            }
            else if (choice == "Meat")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");
                if (customer.WalletBalance < .06)
                {

                    customer.CoinsOwned.Remove(nickel);

                    MachineRegister.Add(nickel);

                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Insufficient funds. Returning money.");
                    Console.WriteLine("-----------------------------");

                    MachineRegister.Remove(nickel);

                    customer.CoinsOwned.Add(nickel);
                }
            }
            else
            {
                Console.WriteLine("Sorry that's  not a flavor available here. Please choose a flavor that's available in this machine.");
                Console.WriteLine("-------------------------------");
                NotEnoughMoney();
            }

        }           //good

        public void ExactPayment()
        {
            //If exact change is passed in, accept payment and dispense a soda from the limited inventory.


            if (choice == "Grape" && grape.amountAvailable <= 0)
            {
                NoSufficientSodaInventory();
            }
            else if (customer.WalletBalance >= .60)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");

                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(dime);


                MachineRegister.Add(quarter);
                MachineRegister.Add(quarter);
                MachineRegister.Add(dime);


                Console.WriteLine("-----------------------------");
                Console.WriteLine("Thank you for your purchase. Dispensing soda.");
                Console.WriteLine("-----------------------------");

                customer.WalletBalance -= .60;

                grape.amountAvailable -= 1;

            }
            else if (choice == "Orange" && orange.amountAvailable <= 0)
            {
                NoSufficientSodaInventory();
            }
            else if (customer.WalletBalance >= .35)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");

                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(dime);


                MachineRegister.Add(quarter);
                MachineRegister.Add(dime);


                Console.WriteLine("-----------------------------");
                Console.WriteLine("Thank you for your purchase. Dispensing soda.");
                Console.WriteLine("-----------------------------");

                customer.WalletBalance -= .35;
                orange.amountAvailable -= 1;


            }
            else if (choice == "Meat" && meat.amountAvailable <= 0)
            {
                NoSufficientSodaInventory();
            }
            else if (customer.WalletBalance >= .06)
                {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");
                
                    customer.CoinsOwned.Remove(nickel);
                    customer.CoinsOwned.Remove(penny);


                    MachineRegister.Add(nickel);
                    MachineRegister.Add(penny);



                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Thank you for your purchase. Dispensing soda.");
                    Console.WriteLine("-----------------------------");

                    customer.WalletBalance -= .06;
                    meat.amountAvailable -= 1;

                
            }
        }       //good

        public void TooMuchMoney()
        {
            //If too much money is passed in, accept the payment, return change as a list of coins from internal, limited register, and return a soda instance from internal, limited inventory.


            if (choice == "Grape" && grape.amountAvailable <= 0)
            {
                NoSufficientSodaInventory();
            }
            else if (choice == "Grape" && customer.WalletBalance > .60)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");

                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(dime);
                customer.CoinsOwned.Remove(dime);


                MachineRegister.Add(quarter);
                MachineRegister.Add(quarter);
                MachineRegister.Add(dime);
                MachineRegister.Add(dime);



                Console.WriteLine("-----------------------------");
                Console.WriteLine("Thank you for your purchase. Dispensing soda.");
                Console.WriteLine("-----------------------------");

                customer.WalletBalance -= .60;

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Returning change.");
                Console.WriteLine("-----------------------------");

                MachineRegister.Remove(dime);
                customer.CoinsOwned.Add(dime);


                grape.amountAvailable -= 1;

            }

            else if (choice == "Orange" && orange.amountAvailable <= 0)
            {
                NoSufficientSodaInventory();
            }
            else if (customer.WalletBalance > .35)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");

                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(dime);
                customer.CoinsOwned.Remove(dime);


                MachineRegister.Add(quarter);
                MachineRegister.Add(dime);
                MachineRegister.Add(dime);


                Console.WriteLine("-----------------------------");
                Console.WriteLine("Thank you for your purchase. Dispensing soda.");
                Console.WriteLine("-----------------------------");

                customer.WalletBalance -= .35;

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Returning change.");
                Console.WriteLine("-----------------------------");

                MachineRegister.Remove(dime);
                customer.CoinsOwned.Add(dime);

                orange.amountAvailable -= 1;


            }
            else if (choice == "Meat" && meat.amountAvailable <= 0)
            {
                NoSufficientSodaInventory();
            }
            else if (choice == "Meat" && customer.WalletBalance > .06)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please dispense money into machine.");
                
                    customer.CoinsOwned.Remove(nickel);
                    customer.CoinsOwned.Remove(penny);
                    customer.CoinsOwned.Remove(nickel);


                    MachineRegister.Add(nickel);
                    MachineRegister.Add(penny);
                    MachineRegister.Add(nickel);



                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Thank you for your purchase. Dispensing soda.");
                    Console.WriteLine("-----------------------------");

                    customer.WalletBalance -= .06;

                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Returning change.");
                    Console.WriteLine("-----------------------------");

                    MachineRegister.Remove(nickel);
                    customer.CoinsOwned.Add(nickel);

                    meat.amountAvailable -= 1;

                }
            }
        public void NoSufficientChangeInRegister()
        {
            //If too much money is passed in but there isn't sufficient change in the machine's internal register, don't complete transaction: give the money back


            if (choice == "Grape" && machineRegisterBalance < .60)
            {


                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(dime);


                MachineRegister.Add(quarter);
                MachineRegister.Add(quarter);
                MachineRegister.Add(quarter);
                MachineRegister.Add(dime);



                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sorry. No sufficient change in machine register. Please try again later.");
                Console.WriteLine("-----------------------------");


                Console.WriteLine("Returning change.");
                Console.WriteLine("-----------------------------");

                MachineRegister.Remove(quarter);
                MachineRegister.Remove(quarter);
                MachineRegister.Remove(dime);
                MachineRegister.Remove(dime);

                customer.CoinsOwned.Add(quarter);
                customer.CoinsOwned.Add(quarter);
                customer.CoinsOwned.Add(dime);
                customer.CoinsOwned.Add(dime);


            }
            else if (choice == "Orange" && machineRegisterBalance < .35)
            {

                customer.CoinsOwned.Remove(quarter);
                customer.CoinsOwned.Remove(dime);
                customer.CoinsOwned.Remove(dime);


                MachineRegister.Add(quarter);
                MachineRegister.Add(dime);
                MachineRegister.Add(dime);



                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sorry. No sufficient change in machine register. Please try again later.");
                Console.WriteLine("-----------------------------");


                Console.WriteLine("Returning change.");
                Console.WriteLine("-----------------------------");

                MachineRegister.Remove(quarter);
                MachineRegister.Remove(quarter);
                MachineRegister.Remove(dime);

                customer.CoinsOwned.Add(quarter);
                customer.CoinsOwned.Add(dime);
                customer.CoinsOwned.Add(dime);


            }
            else if (choice == "Meat" && machineRegisterBalance < .06)
            {

                customer.CoinsOwned.Remove(nickel);
                customer.CoinsOwned.Remove(penny);
                customer.CoinsOwned.Remove(penny);



                MachineRegister.Add(nickel);
                MachineRegister.Add(penny);
                MachineRegister.Add(nickel);


                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sorry. No sufficient change in machine register. Please try again later.");
                Console.WriteLine("-----------------------------");


                Console.WriteLine("Returning change.");
                Console.WriteLine("-----------------------------");

                MachineRegister.Remove(nickel);
                MachineRegister.Remove(penny);
                MachineRegister.Remove(nickel);


                customer.CoinsOwned.Add(nickel);
                customer.CoinsOwned.Add(penny);
                customer.CoinsOwned.Add(nickel);


            }
        }       //good

        public void NoSufficientSodaInventory()
        {
            //If exact or too much money is passed in but there isn't sufficient inventory for that soda, don't complete the transaction: give the money back


            if (grape.amountAvailable <= 0)
            {

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sold out. Please make another selection.");
                Console.WriteLine("-----------------------------");

            }
            else if (orange.amountAvailable <= 0)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sold out. Please make another selection.");
                Console.WriteLine("-----------------------------");
            }
            else if (meat.amountAvailable <= 0)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sold out. Please make another selection.");
                Console.WriteLine("-----------------------------");
            }


        }   //good
        }       
        

    }



