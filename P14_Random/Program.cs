using System;

namespace P14_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Random random = new Random();
            int aRandomNumber = random.Next();
            int aRandomNumber1 = random.Next(4); // 0, 1, 2 arba 3
            int aRandomNumber2 = random.Next(1, 4); // 1, 2, 3
            var bRandomNumber = random.NextDouble(); // nuo 0.0 iki 1.0

            
            Metodas(random);
            Console.WriteLine(bRandomNumber);*/

            Kauliukas();

        }

        /*public static int Metodas(Random rnd) 
        {
            return rnd.Next(1, 10);      
        }*/

        public static void Kauliukas()
        {
            Random random = new Random();
            int kauliukoSkaicius = random.Next(1, 7);
            Console.WriteLine($"{kauliukoSkaicius}");

            switch (kauliukoSkaicius)
            {
                case 1:
                    Console.WriteLine("Kartojame metima);
                    Kauliukas();
                    return;
                case 2:
                    Console.WriteLine("Deja pralaimejote");
                    break;
                case 3:
                    Console.WriteLine("Deja pralaimejote");
                    break;
                case 4:
                    Console.WriteLine("Deja pralaimejote");
                    break;
                case 5:
                    Console.WriteLine("Sveikiname laimejote");
                    break;
                case 6:
                    Console.WriteLine("Sveikiname laimejote");
                    break;
                default:
                    Console.WriteLine("Pasirinkimas neteisingas");
                    break;
            }
        }
    }
}
