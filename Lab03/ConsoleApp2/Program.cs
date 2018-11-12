using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_5
{
    class Program
    {
        private static double doublefahrenheit;
        private static double doubleCelsius;

        public static double Fahrenheit { get; private set; }
        public static int Celsius { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Input temperature in Fahrenheit: ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            double Celsius = (Fahrenheit - 32d) * 5d / 9d;

            Console.WriteLine("Temperature in Celsius is {0}: ", Celsius);

            Console.ReadLine();
            if (Fahrenheit >= 90)
            {
                Console.WriteLine("It is hot");
            }
            if (Fahrenheit <= 40)
            {
                Console.WriteLine("It is cold");
            }
            Console.ReadLine();
        }
    }
}
