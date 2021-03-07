using System;

namespace P08_KondicinesSalygos
{
    class Program
    {
        static void Main(string[] args)
        {

            // IF SALYGA //

            int nelyginisSkaicius = 5;
            int lyginisSkaicius = 2;
            bool tiesa = true;

            if (nelyginisSkaicius > lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");                
            }

            // IF ELSE //

            if (nelyginisSkaicius < lyginisSkaicius)
            {
                Console.WriteLine($"{lyginisSkaicius} yra didesnis uz {nelyginisSkaicius}");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }

            // IF ELSE IF ELSE //

            if (nelyginisSkaicius < lyginisSkaicius && tiesa == true)
            {
                Console.WriteLine($"{lyginisSkaicius} yra didesnis uz {nelyginisSkaicius}");
            }
            else if (nelyginisSkaicius < lyginisSkaicius && tiesa == false)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa == false");
            }
            else if (nelyginisSkaicius > lyginisSkaicius || tiesa == false)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} arba tiesa == false"); // ivykdo sia nes kitos ner true o sita atitinka viena is salygu
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa == true");
            }

            bool arTiesa = nelyginisSkaicius < lyginisSkaicius;
            if (arTiesa)
            {
                Console.WriteLine($"{lyginisSkaicius} yra didesnis uz {nelyginisSkaicius}");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }

            // KONDICINIS OPERATORIUS (SIMPLER IF) //

            int score = 45;
            Console.WriteLine(score > 70 ? "Jus islaikete egzamina": "Jus neislaikete egzamino" ); // salyga,true,false
        }
    }
}
