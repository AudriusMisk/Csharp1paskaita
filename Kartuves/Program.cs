using System;
using System.Linq;

namespace Kartuves
{
    class Program
    {
        static void Main(string[] args)
        {
            ZaidziamasMasyvas();
        }

        static string[] TemosPasirinkimas()
        {
            Console.WriteLine("Temos:");
            Console.WriteLine(" 1 - Vardai \n 2 - Lietuvos miestai \n 3 - Valstybes \n 4 - Vaisiai");
            int temosSkaicius = 0;
            // cia naudoti tryparse
            while (temosSkaicius < 1 || temosSkaicius > 4)
            {
                Console.WriteLine("iveskite temos numeri nuo 1 iki 4");
                var ivestasNumeris = Console.ReadLine();
                temosSkaicius = Convert.ToInt32(ivestasNumeris);
            }
            switch (temosSkaicius)
            {
                case 1:
                    Console.WriteLine("Pasirinkote vardus");
                    string[] varduMasyvas = { "Jonas", "Petras", "Lukas", "Mantas", "Simas", "Marija", "Patricija", "Elena", "Monika", "Andrius" };
                    return varduMasyvas;
                case 2:
                    Console.WriteLine("Pasirinkote lietuvos miestus");
                    string[] miestuMasyvas = { "Vilnius", "Kaunas", "Palanga", "Utena", "Druskininkai", "Trakai", "Panevezys", "Klaipeda", "Jonava", "Zarasai" };
                    return miestuMasyvas;
                case 3:
                    Console.WriteLine("Pasirinkote valstybes");
                    string[] valstybiuMasyvas = { "Lietuva", "Latvija", "Estija", "Vokietija", "Lenkija", "Rusija", "Ispanija", "Graikija", "Italija", "Serbija" };
                    return valstybiuMasyvas;
                case 4:
                    Console.WriteLine("Pasirinkote vaisius");
                    string[] vaisiuMasyvas = { "Obuolys", "Bananas", "Mangas", "Apelsinas", "Mandarinas", "Kriause", "Kivis", "Arbuzas", "Ananasas", "Greipfrutas" };
                    return vaisiuMasyvas;
                default:
                    return null;



            }
        }

        static void ZaidziamasMasyvas()
        {
            string[] zaidziamasMasyvas = TemosPasirinkimas();
            Console.WriteLine(String.Join(",", zaidziamasMasyvas));

            Random random = new Random();
            int randomZodioId = random.Next(10);

            Console.WriteLine($"Pasirinktas zodis yra {zaidziamasMasyvas[randomZodioId]}"); // veliau parasyti tikrinima ar sitas zodis jau buvo naudotas
            char[] zaidziamoZodzioCharMasyvas = zaidziamasMasyvas[randomZodioId].ToCharArray();
            Console.WriteLine(String.Join(",", zaidziamoZodzioCharMasyvas));

            Console.WriteLine("Irasykite spejama raide"); // reikes padaryti kad galima butu irasyti ir pilna zodi
            char spetaRaide = Console.ReadKey().KeyChar;
            if (zaidziamoZodzioCharMasyvas.Contains(spetaRaide))
            {
                Console.WriteLine("atspejote raide");

            }

            Piesinys();
        }

        static void Piesinys()
        {
            Console.WriteLine(@" ------|");
            Console.WriteLine(@"|      o");
            Console.WriteLine(@"|     \|/ ");
            Console.WriteLine(@"|      0");
            Console.WriteLine(@"|     / \");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"----   ");
        }



    }
}
