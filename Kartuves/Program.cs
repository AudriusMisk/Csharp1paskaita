using System;

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
            Console.WriteLine("Iveskite kurios temos zodzius norite spelioti");
            Console.WriteLine(" 1 - Vardai \n 2 - Lietuvos miestai \n 3 - Valstybes \n 4 - Vaisiai");
            int temosSkaicius = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Pasirinkimas neteisingas");
                    TemosPasirinkimas();
                    string[] tusciasMasyvas = {"xxxx"};
                    return tusciasMasyvas;



            }
        }

        static void ZaidziamasMasyvas()
        {
            string[] zaidziamasMasyvas = TemosPasirinkimas();
            Console.WriteLine(String.Join(",", zaidziamasMasyvas));
        }

    }
}
