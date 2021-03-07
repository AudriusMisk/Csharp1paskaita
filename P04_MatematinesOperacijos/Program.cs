using System;

namespace P4_MatematiniaiOperatoriai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematiniai operatoriai + - * / % ++ -- ");
            var lyginisSkaicius = 2;
            var nelyginisSkaicius = 5;
            var sudetis = nelyginisSkaicius + lyginisSkaicius + 1;
            Console.WriteLine($" {nelyginisSkaicius} + {lyginisSkaicius} + 1 = {sudetis}");

            var atimtis = nelyginisSkaicius - 11;
            Console.WriteLine($" {nelyginisSkaicius} - 11 = {atimtis}");

            var daugyba = nelyginisSkaicius * 2;
            Console.WriteLine($"{nelyginisSkaicius} * 2 = {daugyba}");

            double dalyba = daugyba / 3;
            Console.WriteLine("paprasta {0} / 3 = {1}", daugyba, dalyba);

            var dalybaSuCastinimu = (double)daugyba / 3;
            Console.WriteLine("su castinimu {0} / 3 = {1}", daugyba, dalybaSuCastinimu);

            int matematinisRezultatas = 1 + 2 * 5;
            Console.WriteLine(matematinisRezultatas); //matematiniu veiksmu eiliskumo laikomasi

            Console.WriteLine("(%) dalyba su liekana");
            var dalybaSuLiekana = nelyginisSkaicius % 2;
            Console.WriteLine($"{nelyginisSkaicius} % 2 = {dalybaSuLiekana}");

            nelyginisSkaicius++; //tas pat kas nelyginisSkaicius = nelyginisSkaicius +1;
            Console.WriteLine($"padidintaVienetu {nelyginisSkaicius}");

            nelyginisSkaicius--; //tas pat kas nelyginisSkaicius = nelyginisSkaicius - 1;
            Console.WriteLine($"pamazibntaVienetu {nelyginisSkaicius}");


            double a = 3.2;
            double b = -4.3;
            double c = 42;
            double d = -91;
            double e = 4.343;
            double result = (((a + b) * (c - 4)) + d) * e;



            Console.WriteLine("-----Press any key to continue----------");
            Console.ReadKey();
        }
    }
}