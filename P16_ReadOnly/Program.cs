using System;
using System.Collections.Generic;

namespace P16_ReadOnly
{
    class Program
    {
        static string tiesiogTekstas = "labas"; ; // galima pakeisti
        static readonly string tekstasTikSkaitymui = "tik skaitymui"; // negali buti pakeistas
        static readonly int skaiciusTikSkaitymui = 4; // readonly sukuriamas kada programa startuoja
        static readonly List<int> = listas {1, 1, 1};

        const double konstantPi = 3.14; // naudojama absoliuciai globaliems kintamiesiems
        static void Main(string[] args)
        {
            Metodas();
            Console.WriteLine(tiesiogTekstas);

        }

        static void Metodas()
        {
            tiesiogTekstas = "kitas tekstas";
            Console.WriteLine(tiesiogTekstas);
        }
    }
}
