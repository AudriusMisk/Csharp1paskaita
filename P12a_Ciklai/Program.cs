using System;
using System.Collections.Generic;

namespace P12a_Ciklai
{
    class Program
    {
        static void Main(string[] args)
        {
            // WhileLoop();
            // DoWhileLoop();
            // ForLoop();
            // CikloForNutraukimas();
            // CikloWhileNutraukimas();
            // LoopNesting();
            // IgnoringIteration();
            ForEachLoop();

        }

        static void WhileLoop()
        {
            int x = 1;
            while (x < 10)
            {
                Console.WriteLine($"skaicius {x}");
                x++; // didinas x per 1
            }
            //------------------------------------
            int zaidejoNumeris = 0;
            while (zaidejoNumeris < 1 || zaidejoNumeris > 5)
            {
                Console.WriteLine("iveskite zaidejo numeri nuo 1 iki 5");
                var ivestasZaidejoNumeris = Console.ReadLine();
                zaidejoNumeris = Convert.ToInt32(ivestasZaidejoNumeris);
            }


        }
        static void DoWhileLoop()
        {
            int zaidejoNumeris = 2; // visada atliks pirma veiksma nesvarbu koks kintamasis
            do
            {
                Console.WriteLine("iveskite zaidejo numeri nuo 1 iki 5");
                var ivestasZaidejoNumeris = Console.ReadLine();
                zaidejoNumeris = Convert.ToInt32(ivestasZaidejoNumeris);
            }
            while (zaidejoNumeris < 1 || zaidejoNumeris > 5); 

        }
        static void ForLoop()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("xxxcoolxxx");
            }
            
        }
        static void CikloForNutraukimas()
        {
            int blogasSkaicius = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"skaicius {i}");
                if (i == blogasSkaicius)
                {
                    break;
                }
            }

        }
        static void CikloWhileNutraukimas()
        {
            while (true)
            {
                Console.WriteLine("Parasykite ka nors");
                string input = Console.ReadLine();
                if (input == "quit" || input == "exit")
                    break;
            }
        }
        static void LoopNesting() 
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < row + 1; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void IgnoringIteration()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) continue; // 3 bus ignoruotas ir ciklas paleistas is naujo
                Console.WriteLine($"skaicius{i}");
            }
        }
        static void ForEachLoop()
        {
            // for each array
            int[] scores = new int[10];
            foreach (var taskai in scores)
            {
                Console.WriteLine($"Kazkas turi tiek tasku: {taskai}");
            }

            // foreach List
            List<string> vardai = new List<string> { "Jonas", "Agne", "Petras" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"vardas yra {vardas}");
            }

            // foreach aprasytas paprastu for
            for (int i = 0; i < vardai.Count; i++)
            {
                var vardas = vardai[i];
                Console.WriteLine($"vardas yra {vardas}");
            }

            // foreach su dictionary
            Dictionary<int, string> skaiciai = new Dictionary<int, string>
            {
                {1, "vienas" },
                {2, "du" },
                {3, "trys" },
            };
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine($"skaicius: Key = {skaicius.Key} Value = {skaicius.Value}");
            }

            //stirnga keicia i char masyva
            string tekstas = "Kazkas svarbaus";
            foreach (var raide in tekstas)
            {
                Console.WriteLine($"raide - {raide}");
            }
        }
    }
}
