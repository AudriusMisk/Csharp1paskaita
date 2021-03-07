using System;

namespace P11_Metodai
{
    class Program
    {
        static void Main(string[] args)
        {

            IsveskIekranaKazka();
            //
            float kazkoksAtsitiktinisSkaicius = GautiAtsitiktiniSkaiciu(); // sukuriam kintamaji ir kvieciam metoda kuris grazina skaiciu 4.38
            Console.WriteLine(kazkoksAtsitiktinisSkaicius);
            //
            IsveskEkrananSkaiciu(5);
            //
            IsveskEkrananDaugiauSkaiciu(2, 4);
            //
            int sandauga1 = DaugintiSkaicius(2, 2);
            Console.WriteLine($"Sandauga lygi = {sandauga1}");
            //
            TekstasEkrane();
            TekstasEkrane("Kitas tekstas ekrane");
            //
            var dalybosRezultatas = DalybaIrLiekana(5, 2, out int lik);
            Console.WriteLine($"rezultatas = {dalybosRezultatas} ir liekana = {lik}");
            //
            int kintamasisSkaicius = 1;
            SkaiciusReference(ref kintamasisSkaicius); // iraso kintamaji i metoda ir pakeiciamas metodo viduje
            Console.WriteLine(kintamasisSkaicius);
        }

        static void IsveskIekranaKazka() // void reiskia kad metodas negrazina jokios reiksmes
        {
            Console.WriteLine("kazkas");
        }

        static float GautiAtsitiktiniSkaiciu() // metodas kuris grazina float tipo skaiciu
        {
            return 4.38F;
        }
        static void IsveskEkrananSkaiciu(int skaicius)
        {
            Console.WriteLine($"gautas skaicius = {skaicius}");
        }

        static void IsveskEkrananDaugiauSkaiciu(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"gautas skaicius1 = {skaicius1}, gautas skaicius2 = {skaicius2}");
        }

        static int DaugintiSkaicius(int a, int b)
        {
            return a * b;
        }

        static int DaugintiSkaicius(int a, int b, int c) // galima turetu vienodus pavadinimus jeigu skirias parametru kiekis 
        {
            return a * b * c;
        }

        static void TekstasEkrane(string tekstas = "Labas pasauli") // turi defaultini teksta kuris bus isspausdintas jei nepaduosim jokio teksto
        {
            Console.WriteLine($"tekstas: {tekstas}"); 
        }

        static int DalybaIrLiekana(int skaicius, int daliklis, out int liekana)
        { 
            liekana = skaicius % daliklis;
            return skaicius / daliklis;
        }

        static void SkaiciusReference(ref int skaicius) 
        {
            skaicius = 50;
        }
    }
}
