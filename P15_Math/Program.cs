using System;

namespace P15_Math
{
    class Program
    {
        static void Main(string[] args)
        {

            double pi_value = Math.PI;
            Console.WriteLine(pi_value);
            Console.WriteLine("Floor value of 123.123: " + Math.Floor(123.123)); // paema sveika
            Console.WriteLine("Round value of 14.6534: " + Math.Round(14.6534)); // suapvalina
            Console.WriteLine("Square root of 81: {0}", Math.Sqrt(81));

            double num2 = -1.23456789;
            Console.WriteLine($"absolute value of{num2} is {Math.Abs(num2)}");

            var dalmuo = Math.DivRem(2, 3, out int liekana);

            var laipsnis = Math.Pow(2, 3);

            Console.WriteLine($"Keliomas laipsniu {laipsnis}");

        }
    }
}
