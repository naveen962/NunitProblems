using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyPayment
    {
        class Program
        {
        public static void MontlyPayment(int Principleamount, int NoOfYear, float Rate)
        {
            float r = Rate / (12 * 100);
            int n = 12 * NoOfYear;
            double payment = (Principleamount * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Montly payment will be {0}", payment);
        }
            static void Main(string[] args)
            {
                
                Console.WriteLine("Enter Principle amount, no. of years and Rate of intrest");
                int Principleamount = int.Parse(Console.ReadLine());
                int NoOfYear = int.Parse(Console.ReadLine());
                int Rate = int.Parse(Console.ReadLine());
                Program.MontlyPayment(Principleamount, NoOfYear, Rate);
        }
    }
}
