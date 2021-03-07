using System;

namespace MetoduUzduotys
{
    class Program
    {
        static void Main(string[] args)
        {

            bool tiesaArMelas = ArLygusKintamieji(3,3,3);
            Console.WriteLine($"Are numbers equal to each other ? : {tiesaArMelas}");

            /*int a = 6;
            int b = 3;
            int suma = Suma(a, b);
            int atimtis = Atimtis(a, b);
            int dalyba = Dalyba(a, b);
            int daugyba = Daugyba(a, b);
          
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Atimtis: {atimtis}");
            Console.WriteLine($"Dalyba {dalyba}");
            Console.WriteLine($"Daugyba: {daugyba}");
            Console.WriteLine($"Visu suma: {suma+atimtis+dalyba+daugyba}");*/
        }
        /*static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Atimtis(int a, int b)
        {
            return a - b;
        }
        static int Dalyba(int a, int b)
        {
            return a / b;
        }
        static int Daugyba(int a, int b)
        {
            return a * b;
        }*/

        static bool ArLygusKintamieji(int pirmas, int antras, int trecias)
        {
            if (pirmas == antras && pirmas == trecias && antras == trecias)
            {
                Console.WriteLine("Kintamieji lygus");
                return true;
            }
            else
            {
                Console.WriteLine($"Kintamieji nelygus: {pirmas} , {antras}, {trecias}");
                return false;
            }
        }

    }
}
