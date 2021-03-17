using System;
using System.Text;

namespace Testai
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string vardas1 = "Petras";
            string vardas2 = "Paulius";
            string vardas3 = "Jonas";
            int kavosIsgerta = 12;

            Console.WriteLine($"{vardas1}, {vardas2} ir {vardas3} isgere {kavosIsgerta} kavos puodeliu"); // INTERPOLATION

            var kavosPuodeliuKiekis = string.Format("{0}, {1}, {2} isgere {3} puodeliu kavos", vardas1, vardas2, vardas3, kavosIsgerta); // COMPOSITION

            Console.WriteLine(kavosPuodeliuKiekis);
            Console.WriteLine($"\"kompiuteris su Windows {Environment.NewLine}            su Linux {Environment.NewLine}            su Mac\"");
            string _verbatim = @" ""kompiuteris su Windows
            su Linux
            su Mac""";

            Console.WriteLine(_verbatim);

            var _verbatimDidziosiomis = _verbatim.ToUpper(); // keitimas i didziasias raides

            Console.WriteLine(_verbatimDidziosiomis);

            StringBuilder sb = new StringBuilder(_verbatim); 
            Console.WriteLine(sb);

            Console.WriteLine($"Simbliu kiekis yra {sb.Length}"); // simboliu kiekis tekste*/

            /*int kavosPuodeliai = 15;
            int nemokamiPuodeliai = 0;
            if (kavosPuodeliai >= 3)
            {
                nemokamiPuodeliai = kavosPuodeliai / 3;
                Console.WriteLine($"Nemokamu puodeliu turite:{nemokamiPuodeliai}");
            }
            else
            {
                Console.WriteLine("Nemokamu kavos puodeliu neturite");
            }

            int a = 5;
            int b = 15;
            int c = -10;
            int d = 0;

            if ()*/


            /*Console.WriteLine("Iveskite 3 draugu vardus");
            string draugas1 = Console.ReadLine();
            string draugas2 = Console.ReadLine();
            string draugas3 = Console.ReadLine();

            Console.WriteLine($"Iveskite {draugas1} amziu");
            int draugas1Amzius = int.Parse(Console.ReadLine());
            Console.WriteLine($"Iveskite {draugas2} amziu");
            int draugas2Amzius = int.Parse(Console.ReadLine());
            Console.WriteLine($"Iveskite {draugas3} amziu");
            int draugas3Amzius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Vardas:{draugas1} Amzius:{draugas1Amzius} ");
            Console.WriteLine($"Vardas:{draugas2} Amzius:{draugas2Amzius} ");
            Console.WriteLine($"Vardas:{draugas3} Amzius:{draugas3Amzius} ");
            double bendrasAmzius = (double)(draugas1Amzius + draugas2Amzius + draugas3Amzius) / 3;
            Console.WriteLine($"Amziaus vidurkis : {bendrasAmzius}");

            if (draugas1Amzius < draugas2Amzius && draugas1Amzius < draugas3Amzius)
            {
                Console.WriteLine($"Jauniausias draugas : {draugas1} {draugas1Amzius} metu");
            }
            else if (draugas2Amzius < draugas1Amzius && draugas2Amzius < draugas3Amzius)
            {
                Console.WriteLine($"Jauniausias draugas : {draugas2} {draugas2Amzius} metu");
            }
            else
            {
                Console.WriteLine($"Jauniausias draugas : {draugas3} {draugas3Amzius} metu");
            }

            if (draugas1Amzius > draugas2Amzius && draugas1Amzius > draugas3Amzius)
            {
                Console.WriteLine($"Vyriausias draugas : {draugas1} {draugas1Amzius} metu");
            }
            else if (draugas2Amzius > draugas1Amzius && draugas2Amzius > draugas3Amzius)
            {
                Console.WriteLine($"Vyriausias draugas : {draugas2} {draugas2Amzius} metu");
            }
            else
            {
                Console.WriteLine($"Vyriausias draugas : {draugas3} {draugas3Amzius} metu");
            }*/

            /* Console.WriteLine("Iveskite 4 datas");
             var ivestaData1 = DateTime.Parse(Console.ReadLine());
             var ivestaData2 = DateTime.Parse(Console.ReadLine());
             var ivestaData3 = DateTime.Parse(Console.ReadLine());
             var ivestaData4 = DateTime.Parse(Console.ReadLine());

             Console.WriteLine($"Ivesta {ivestaData1}, {ivestaData2}, {ivestaData3}, {ivestaData4}");

             if (ivestaData1.Month == 12 && ivestaData1.Day == 24)
             {
                 Console.WriteLine("Jums priklauso nemokami kaledu sausainiai");
             }
             else if (ivestaData2.Month == 12 && ivestaData2.Day == 24)
             {
                 Console.WriteLine("Jums priklauso nemokami kaledu sausainiai");
             }
             else if (ivestaData3.Month == 12 && ivestaData3.Day == 24)
             {
                 Console.WriteLine("Jums priklauso nemokami kaledu sausainiai");
             }
             else if (ivestaData4.Month == 12 && ivestaData4.Day == 24)
             {
                 Console.WriteLine("Jums priklauso nemokami kaledu sausainiai");
             }
             else
             {
                 Console.WriteLine("Palaukite kaledu");
             }*/


            int[] masyvasInt = new int[5] { 5, 87, 42, 54, 12 };
            Console.WriteLine($"Dvieju elementu suma: {masyvasInt[0] + masyvasInt[4]}");

            string[] masyvasString = new string[4] {"Jonas", "Petras", "Antanas", "Juozas" };
            Console.WriteLine(string.Join(" ", masyvasString) );

            string vardas = "Vytas";
            masyvasString[3] = vardas;

            Console.WriteLine(string.Join(" ", masyvasString));

        }
    }
}
