using System;
using System.Collections.Generic;
using System.Linq;

namespace Kartuves
{
    class Program
    {
        static int neatspetosRaides = 0;
        static int atspetosRaides = 0;
        static char[] zaidziamoZodzioCharMasyvas;
        static List<char> raidziuListas;
        static Dictionary<int, char> raidziuZodynas = new Dictionary<int, char>();
        static List<char> spetosRaides = new List<char>();
        static List<string> miestai = new List<string> { "Vilnius", "Kaunas", "Palanga", "Utena", "Druskininkai", "Trakai", "Panevezys", "Klaipeda", "Jonava", "Zarasai" };
        static List<string> valstybes = new List<string> { "Lietuva", "Latvija", "Estija", "Vokietija", "Lenkija", "Rusija", "Ispanija", "Graikija", "Italija", "Serbija" };
        static List<string> vaisiai = new List<string> { "Obuolys", "Bananas", "Mangas", "Apelsinas", "Mandarinas", "Kriause", "Kivis", "Arbuzas", "Ananasas", "Greipfrutas" };
        static List<string> vardai = new List<string> { "Jonas", "Petras", "Lukas", "Mantas", "Simas", "Marija", "Patricija", "Elena", "Monika", "Andrius" };
        static void Main(string[] args)
        {
            ZaidziamasMasyvas();
            Console.ReadKey();

        }

        static string[] TemosPasirinkimas()
        {
            Console.WriteLine("\nTemos:");
            Console.WriteLine(" 1 - Vardai \n 2 - Lietuvos miestai \n 3 - Valstybes \n 4 - Vaisiai");
            int temosSkaicius = 0;
            while (temosSkaicius < 1 || temosSkaicius > 4 )
            {
                Console.WriteLine("Iveskite temos numeri nuo 1 iki 4");
                var ivestasNumeris = Console.ReadLine();
                Int32.TryParse(ivestasNumeris, out temosSkaicius);
            }
            switch (temosSkaicius)
            {
                case 1:
                    Console.WriteLine("Pasirinkote vardus");
                    string[] zaidziamasVarduMasyvas = vardai.ToArray();
                    return zaidziamasVarduMasyvas;
                case 2:
                    Console.WriteLine("Pasirinkote lietuvos miestus");
                    string[] zaidziamasMiestuMasyvas = miestai.ToArray();
                    return zaidziamasMiestuMasyvas;
                case 3:
                    Console.WriteLine("Pasirinkote valstybes");
                    string[] zaidziamasValstybiuMasyvas = valstybes.ToArray();
                    return zaidziamasValstybiuMasyvas;
                case 4:
                    Console.WriteLine("Pasirinkote vaisius");
                    string[] zaidziamasVaisiuMasyvas = vaisiai.ToArray();
                    return zaidziamasVaisiuMasyvas;
                default:
                    return null;



            }
        }

        static void ZaidziamasMasyvas()
        {
            
            string[] zaidziamasMasyvas = TemosPasirinkimas();
            if (zaidziamasMasyvas == null || zaidziamasMasyvas.Length == 0)
            {
                Console.WriteLine("Sioje kategorijoje zodziu nebeliko prasome pasirinkti kita");
                ZaidziamasMasyvas();
            }
            Console.WriteLine(String.Join(",", zaidziamasMasyvas));

            Random random = new Random();
            int randomZodioId = random.Next(zaidziamasMasyvas.Length);
            Console.WriteLine($"Pasirinktas zodis yra {zaidziamasMasyvas[randomZodioId]}");
            zaidziamoZodzioCharMasyvas = zaidziamasMasyvas[randomZodioId].ToCharArray();

            if (zaidziamasMasyvas.SequenceEqual(vardai.ToArray()))
            {
                vardai.RemoveAt(randomZodioId);
            }
            if (zaidziamasMasyvas.SequenceEqual(miestai.ToArray()))
            {
                miestai.RemoveAt(randomZodioId);
            }
            if (zaidziamasMasyvas.SequenceEqual(vaisiai.ToArray()))
            {
                vaisiai.RemoveAt(randomZodioId);
            }
            if (zaidziamasMasyvas.SequenceEqual(valstybes.ToArray()))
            {
                valstybes.RemoveAt(randomZodioId);
            }


            Console.WriteLine(String.Join(",", zaidziamoZodzioCharMasyvas));
            raidziuListas = zaidziamoZodzioCharMasyvas.ToList();
            SpekZodiArRaide();
        }

        static void SpekRaide()
           {
            Console.WriteLine("\nIrasykite spejama raide");
            char spetaRaide;
            char.TryParse(Console.ReadLine(), out spetaRaide);
            while (spetosRaides.Contains(spetaRaide))
            {
                Console.WriteLine("Irasete jau speta raide, prasome irasyti nauja");
                char.TryParse(Console.ReadLine(), out spetaRaide);
            }
            spetosRaides.Add(spetaRaide);           
            //raidziuListas = zaidziamoZodzioCharMasyvas.ToList();            
            if (raidziuListas.Contains(spetaRaide))
            {
                
                while (raidziuListas.Contains(spetaRaide))
                {
                    raidziuListas.Remove(spetaRaide);
                    atspetosRaides++;
                }

                for (int i = 0; i < zaidziamoZodzioCharMasyvas.Length; i++)
                {
                    if (zaidziamoZodzioCharMasyvas[i] == spetaRaide)
                    {
                        raidziuZodynas.Add(i, spetaRaide);
                    }
                }

                Console.WriteLine(String.Join(",", raidziuListas));
                Piesinys(neatspetosRaides);
            }
            else
            {
                neatspetosRaides++;
                Console.WriteLine(neatspetosRaides);
                Piesinys(neatspetosRaides);
            }

            }

        static void Piesinys(int neatspetosRaides)
        {    
            if (neatspetosRaides >= 7)
            {
                
                Console.WriteLine(@" ------|");
                Console.WriteLine(@"|      o");
                Console.WriteLine(@"|     \|/");
                Console.WriteLine(@"|      0");
                Console.WriteLine(@"|     / \");
                Console.WriteLine(@"|   ");
                Console.WriteLine(@"|   ");
                Console.WriteLine(@"|   ");
                Console.WriteLine(@"----   ");

                Console.WriteLine("JUST PRALAIMEJOTE !");
                ZaidimasIsNaujo();
            }
            else
            {
                switch (neatspetosRaides)
                {
                    case 0:
                        Console.WriteLine(@" ------|");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"----   ");
                        break;
                    case 1:
                        Console.WriteLine(@" ------|");
                        Console.WriteLine(@"|      o");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"----   ");
                        break;
                    case 2:
                        Console.WriteLine(@" ------|");
                        Console.WriteLine(@"|      o");
                        Console.WriteLine(@"|      |");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"----   ");
                        break;
                    case 3:
                        Console.WriteLine(@" ------|");
                        Console.WriteLine(@"|      o");
                        Console.WriteLine(@"|      |");
                        Console.WriteLine(@"|      0");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"----   ");
                        break;
                    case 4:
                        Console.WriteLine(@" ------|");
                        Console.WriteLine(@"|      o");
                        Console.WriteLine(@"|     \|");
                        Console.WriteLine(@"|      0");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"----   ");
                        break;
                    case 5:
                        Console.WriteLine(@" ------|");
                        Console.WriteLine(@"|      o");
                        Console.WriteLine(@"|     \|/");
                        Console.WriteLine(@"|      0");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"----   ");
                        break;
                    case 6:
                        Console.WriteLine(@" ------|");
                        Console.WriteLine(@"|      o");
                        Console.WriteLine(@"|     \|/");
                        Console.WriteLine(@"|      0");
                        Console.WriteLine(@"|     /");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"|   ");
                        Console.WriteLine(@"----   ");
                        break;
                    default:
                        Console.WriteLine("Pasirinkimas neteisingas");
                        break;
                }

                ZodzioSpausdinimas();
                Console.Write("\nSpetos raides: ");
                Console.Write(String.Join(",", spetosRaides));
                Laimejimas();
                SpekRaide();
            }
        }

        static void StartPiesinys()
        {
            Console.WriteLine(@" ------|");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"|   ");
            Console.WriteLine(@"----   ");
        }

        static void ZodzioSpausdinimas()
        {
            int raidziuSkaicius = zaidziamoZodzioCharMasyvas.Length;
            Console.Write("Zodis:");
            for (int i = 0; i < raidziuSkaicius; i++)
            {
                if (raidziuZodynas.ContainsKey(i))
                {
                    Console.Write($"{raidziuZodynas[i]}");
                }
                else
                {
                   Console.Write("_ ");
                }
                
            }
        }

        static void SpekZodi()
        {
            Console.WriteLine("\nIrasykite spejama zodi");
            string spetasZodis = Console.ReadLine();
            char [] spetasZodisArray = spetasZodis.ToCharArray();
            string spetasString = string.Join("", spetasZodisArray);
            string zaidziamasString = string.Join("", zaidziamoZodzioCharMasyvas);
            if (spetasString == zaidziamasString)
            {
                Console.WriteLine("Jus laimejote");
                ZaidimasIsNaujo();
            }
            else
            {
                Console.WriteLine("Jus pralaimejote");
                ZaidimasIsNaujo();
            }
        }

        static void SpekZodiArRaide()
        {
            int pasirinkimoSkaicius = 0;
            while (pasirinkimoSkaicius < 1 || pasirinkimoSkaicius > 2)
            {
                Console.WriteLine("Jei norite speti raide iveskite 1, jei visa zodi iveskite 2");
                var ivestasNumeris = Console.ReadLine();
                Int32.TryParse(ivestasNumeris, out pasirinkimoSkaicius);
            }
            if (pasirinkimoSkaicius == 1)
            {
                StartPiesinys();
                ZodzioSpausdinimas();
                SpekRaide();
            }
            if (pasirinkimoSkaicius == 2)
            {
                StartPiesinys();
                ZodzioSpausdinimas();
                SpekZodi();
            }
        }

        static void Laimejimas()
        
        {
            bool isEmpty = !raidziuListas.Any();
            if (isEmpty)
            {
                Console.WriteLine("\nJus laimejote");
                ZaidimasIsNaujo();
            }

        }

        static void ZaidimasIsNaujo()
        {
            atspetosRaides = 0;
            neatspetosRaides = 0;
            raidziuZodynas.Clear();
            spetosRaides.Clear();
            char ne = 'n';
            char taip = 't';
            Console.WriteLine("\nAr norite zaisti dar karta ? t/n");
            char userCharEntered = Console.ReadKey().KeyChar;
            if (userCharEntered == taip)
            {
                ZaidziamasMasyvas();
                userCharEntered = Console.ReadKey().KeyChar;
            }
            if (userCharEntered == ne)
            {
                Environment.Exit(1);
            }
            else
            {
                ZaidimasIsNaujo();
            }

        }

    }
}
