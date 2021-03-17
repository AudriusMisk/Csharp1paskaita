using System;

namespace P14_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int aRandomNumber = random.Next();
            int aRandomNumber1 = random.Next(4); // 0, 1, 2 arba 3
            int aRandomNumber2 = random.Next(1, 4); // 1, 2, 3
            var bRandomNumber = random.NextDouble(); // nuo 0.0 iki 1.0

            
            Metodas(random);

            Console.WriteLine(bRandomNumber);
        }

        public static int Metodas(Random rnd)
        {
            return rnd.Next(1, 10);      
        }

        
    }
}
