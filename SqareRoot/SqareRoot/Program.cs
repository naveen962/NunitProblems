using System;
//using System.Collections.Generic;
//using System.Text;

namespace SqareRoot
{
    class Program
    {
        public static void getSquareRoot(double c)
        {
            double t = c;
            const double Epsilon = 1E-15;
            double squareRoot;
            while (true)
            {
                squareRoot = 0.5 * (t + (c / t));
                if (Math.Abs(squareRoot - t) < Epsilon)
                    break;
                t = squareRoot;
            }
            Console.WriteLine("{0} square root is {1}", c, squareRoot);
        }
       static void Main(String [] args)
        {
           
            Console.WriteLine("Enter number to find square root");
            int numsqrt = int.Parse(Console.ReadLine());
            Program.getSquareRoot(numsqrt);
        }
    }
}