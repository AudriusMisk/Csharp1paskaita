using System;

namespace P6_ReliaciniaiOperatoriai
{
    class Program
    {
        static void Main(string[] args)
        {
            var lyginisSkaicius = 2;
            var nelyginisSkaicius = 5;
            var skaicius = 2;
            Console.WriteLine("Reliaciniai operatoriai == != > < >= <=");
            Console.WriteLine($"(==) Patikrina ar du skaičiai yra lygūs");
            bool arLygus = nelyginisSkaicius == lyginisSkaicius;
            Console.WriteLine($"{nelyginisSkaicius} == {lyginisSkaicius} {arLygus}");
            Console.WriteLine($"{skaicius} == {lyginisSkaicius} {skaicius == lyginisSkaicius}");
            Console.WriteLine($"(!=) Patikrina ar du skaičiai yra nelygūs");
            Console.WriteLine($"{nelyginisSkaicius} != {lyginisSkaicius} {nelyginisSkaicius != lyginisSkaicius}");
            Console.WriteLine($"{skaicius} != {lyginisSkaicius} {skaicius != lyginisSkaicius}");
            Console.WriteLine($"(>) Patikrina ar pirmas skaičius didesnis už antrą");
            Console.WriteLine($"{nelyginisSkaicius} > {lyginisSkaicius} {nelyginisSkaicius > lyginisSkaicius}");
            Console.WriteLine($"(<) Patikrina ar pirmas skaičius mažesnis už antrą");
            Console.WriteLine($"{nelyginisSkaicius} < {lyginisSkaicius} {nelyginisSkaicius < lyginisSkaicius}");
            Console.WriteLine($"{skaicius} < {lyginisSkaicius} {skaicius < lyginisSkaicius}");
            Console.WriteLine($"(>=) Patikrina ar pirmas skaičius didesnis arba lygus už antrą");
            Console.WriteLine($"{nelyginisSkaicius} >= {lyginisSkaicius}  {nelyginisSkaicius >= lyginisSkaicius}");
            Console.WriteLine($"(<=) Patikrina ar pirmas skaičius mažesnis arba lygus už antrą");
            Console.WriteLine($"{nelyginisSkaicius} <= {lyginisSkaicius} {nelyginisSkaicius <= lyginisSkaicius}");
            Console.WriteLine($"{skaicius} <= {lyginisSkaicius} {skaicius <= lyginisSkaicius}");

            Console.WriteLine("-----Press any key to continue----------");
            Console.ReadKey();
        }
    }
}