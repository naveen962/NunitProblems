using System;


namespace VendingMachine
{
    class Program
    {
        public static void FindChanges(int amount)
        {
            int note = 0;
            int amt = amount;
            int thousandcount = 0;
            int hundredcount = 0;
            int fivehundredcount = 0;
            int fiftycount = 0;
            int tencount = 0;
            int fivecount = 0;
            int twocount = 0;
            int onecount = 0;
           
            while (amount > 0)
            {
                if (amount >= 1000)
                {
                    amount -= 1000;
                    thousandcount++;
                    note++;
                }
                else if (amount >= 500)
                {
                    amount -= 500;
                    fivehundredcount++;
                    note++;
                }
                else if (amount >= 100)
                {
                    amount -= 100;
                    hundredcount++;
                    note++;
                }
                else if (amount >= 50)
                {
                    amount -= 50;
                    fiftycount++;
                    note++;
                }
                else if (amount >= 10)
                {
                    amount -= 10;
                    tencount++;
                    note++;
                }
                else if (amount >= 5)
                {
                    amount -= 5;
                    fivecount++;
                    note++;
                }
                else if (amount >= 2)
                {
                    amount -= 2;
                    twocount++;
                    note++;
                }
                else 
                {
                    amount -= 1;
                    onecount++;
                    note++;
                }
               
            }
            Console.WriteLine("Number of notes required to give {0} is {1}", amt, note);
            Console.WriteLine("No of Thousands notes = " + thousandcount);
            Console.WriteLine("No of Fivehundreds notes = " + fivehundredcount);
            Console.WriteLine("No of Hundreds notes = " + hundredcount);
            Console.WriteLine("No of Fiftys notes = " + fiftycount);
            Console.WriteLine("No of Tens notes = " + tencount);
            Console.WriteLine("No of Fives notes = " + fivecount);
            Console.WriteLine("No of Twos notes = " + twocount);
            Console.WriteLine("No of ones notes = " + onecount);

        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter amount to get change from vending machine");
            int amount = int.Parse(Console.ReadLine());
           
            Program.FindChanges(amount);
        }
    }
}
