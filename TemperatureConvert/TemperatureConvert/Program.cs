using System;


namespace TemperatureConvert
{
    class Program
    {
        public static void CelsiusToFahrenheit(int temp)
        {
            //(°C × 9/5) + 32 = °F
            int Celsius = temp * (9 / 5) + 32;
            Console.WriteLine("{0} celsius into {1} fahrenheit", temp, Celsius);
        }
        public static void FahrenheitToCelsius(int temp)
        {
            //(°F − 32) x 5/9 = °C
            int Fahrenheit = (temp - 32) * 5 / 9;
            Console.WriteLine("{0} fahrenheit = {1} ", temp, Fahrenheit);
        }

        public static void Main(String [] args)
        {
           
            Console.WriteLine("Enter temprature in number");
            int tempNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Select convertion");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Program.CelsiusToFahrenheit(tempNumber);
            }
            else if (option == 2)
            {
                Program.FahrenheitToCelsius(tempNumber);
            }
            else
            {
                Console.WriteLine("Enter valid input option");
            }
        }

    }
}