using System;
using System.Collections.Generic;

namespace Uzduotis1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite svarbumo lygmeni nuo 0 iki 2 \n 0 - Low\n 1 - Medium\n 2 - High");
            Switch();
        }

        enum Level { Low = 0, Medium = 1, High = 2 };

        static void Switch()
        {
            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 0:
                    Console.WriteLine($"{Level.Low} level");
                    break;
                case 1:
                    Console.WriteLine($"{Level.Medium} level");
                    break;
                case 2:
                    Console.WriteLine($"{Level.High} level");
                    break;
                default:
                    Console.WriteLine("Pasirinkimas neteisingas");
                    break;

            }


        }
    }
}
