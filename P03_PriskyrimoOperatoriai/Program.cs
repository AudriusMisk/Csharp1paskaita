using System;

namespace P3_PriskyrimoOperatoriai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Priskyrimo operatoriai = += -= *= /= ");
            Console.WriteLine("(=) paprastas priskyrimas");
            int naujasSkaicius;
            naujasSkaicius = 5;

            Console.WriteLine("(+=) pridedantis priskyrimas (Compound Assignment Operators)");
            int a = 5;
            a += 3;  //tas pat kas  a = a + 3;

            Console.WriteLine($"(-=) pridedantis priskyrimas (Compound Assignment Operators)");
            int b = 5;
            b -= 3;  //tas pat kas b = b - 3;


            Console.WriteLine("--UŽDUOTIS--");
            Console.WriteLine("1. sukurkite naują kintamajį long tipo pavadinimu 'didelisSkaicius' ir priskirkite didžiausią galimą reikšmę. Išveskite į ekraną");



            Console.WriteLine("-----Press any key to continue----------");
            Console.ReadKey();
        }
    }
}