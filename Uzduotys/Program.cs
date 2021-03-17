using System;

namespace Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadIntNumber();
        }

        static void ReadIntNumber()            
        {
            Console.WriteLine("Iveskite sveikaji skaiciu");
            string skaiciusStr = string.Empty;
            bool arSkaiciusTeisingas = false;
            while (!arSkaiciusTeisingas)
            {
                skaiciusStr = Console.ReadLine();
                arSkaiciusTeisingas = int.TryParse(skaiciusStr, out _);
                if (!arSkaiciusTeisingas) Console.WriteLine("Ivestas skaicius neteisingas, bandykite dar");
            }

            Console.WriteLine($"Ivestas skaicius: {skaiciusStr}");
        }
    }
}
