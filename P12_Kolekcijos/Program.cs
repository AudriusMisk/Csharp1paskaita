using System;
using System.Collections.Generic;

namespace P12_Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Masyvai();
            //Sarasai();
            //Zodynai();

            int savaitesdiena = (int)DaysOfWeek.Friday; // duoda indexa
            Console.WriteLine($"savaitesdiena {savaitesdiena}");


            Console.WriteLine("Iveskite svarbumo lygmeni nuo 0 iki 2 \n 0 - Low\n 1 - Medium\n 2 - High");
          /*  Switch();*/
            EnumTask2();

        }

        static void Masyvai()
        {
            // tuscias masyvas kuris neturi savyje nieko
            int[] tusciasMasyvas;

            //masyvas kuris talpina 10 skaiciu, 3 zodzius, 5 datas
            int[] skaiciai = new int[10];
            string[] zodziai = new string[3];
            DateTime[] datos = new DateTime[5];

            //realus masyvas
            skaiciai[0] = 100;
            skaiciai[1] = 95;
            skaiciai[2] = 92;

            int[] intMasyvas1 = new int[] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 }; // masyvas pats paskirs kiek reik vietos
            int[] intMasyvas4 = new[] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };
            int[] intmasyvas2 = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 }; // turi buti 10 elementu
            int[] intMasyvas3 = { 12, 25, 523, 23, 45 };

            //masyvo reiksmes pagal indeksa
            Console.WriteLine($"{intMasyvas1[0]} + {intMasyvas1[4]} = {intMasyvas1[0] + intMasyvas1[4]}");

            string[] vardai = { "Jonas", "Petras", "Antanas", "Ignas" };
            Console.WriteLine($"{vardai[0]} {vardai[1]} {vardai[2]} {vardai[3]}");

            vardai[3] = "Agne";
            Console.WriteLine($"{vardai[0]} {vardai[1]} {vardai[2]} {vardai[3]}");

            string vardas = vardai[2]; // priskiriam masyvo elementa naujam kintamajam
            string vardas2 = "Vardas";
            vardai[1] = vardas2;
            Console.WriteLine($"{vardai[0]} {vardai[1]} {vardai[2]} {vardai[3]}");

            int totalThingsInArray = intMasyvas1.Length; // kiek elementu masyve
            Console.WriteLine($"masyve yra {totalThingsInArray} dalyku");

            string tekstas = "Kazkas svarbaus";
            char[] tekstoRaides = tekstas.ToCharArray();
            Console.WriteLine($"teksto trecia raide {tekstoRaides[2]}");

            // UZDUOTIS //


            int[] masyvasInt = new int[5] { 5, 87, 42, 54, 12 };
            Console.WriteLine($"Dvieju elementu suma: {masyvasInt[0] + masyvasInt[4]}");

            string[] masyvasString = new string[4] { "Jonas", "Petras", "Antanas", "Juozas" };
            Console.WriteLine(string.Join(" ", masyvasString));

            string vardaz = "Vytas";
            masyvasString[3] = vardaz;

            Console.WriteLine(string.Join(" ", masyvasString));

        } // Array

        static void Matricos()
        {
            int[,] matrix = new int[4, 4];  // kiekviena eilute turi tiek pat stulpeliu
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[4, 4] = 10;

            //array in array
            int[][] matrix1 = new int[4][]; //kiekviena eilute gali tureti skirtinga kieki stulpeliu
            matrix1[0] = new int[4];
            matrix1[1] = new int[5];
            matrix1[2] = new int[2];
            matrix1[3] = new int[6];

        }

        static void Sarasai() // List
        {
            //Listus galima padidinti pamazinti vietos atzvilgiu

            List<string> listOfStrings = new List<string>(); // butina nurodyti ka listas talpina

            List<int> skaiciai = new List<int> { 1, 22, 33, 44, 5 };
            List<string> automobiliai = new List<string> { "Audi", "VW", "Opel", "Volvo" };

            Console.WriteLine(skaiciai[1]);
            Console.WriteLine(automobiliai[1]);

            //Reiksmiu keitimas
            automobiliai[1] = "BMW";

            //Listo reiksmes gaunamos pagal indeksa
            Console.WriteLine(skaiciai[0] * skaiciai[4]);
            Console.WriteLine(string.Join(" ", automobiliai));
            Console.WriteLine(automobiliai[3]);

            automobiliai.Add("Citroen"); // prideda nauja elementa gale
            Console.WriteLine(string.Join(" ", automobiliai));

            automobiliai.Insert(1, "Lada"); // iterpia nauja elementa kur nurodote
            Console.WriteLine(string.Join(" ", automobiliai));

            automobiliai.RemoveAt(0); // panaikina nurodytam indekse esanti kintamaji
            Console.WriteLine(string.Join(" ", automobiliai));

            //Isvalyti lista
            skaiciai.Clear();

            int kiekis = automobiliai.Count; // Listo kintamuju kiekis
            Console.WriteLine($"Kiekis: {kiekis}");

            //Masyvo gavimas is listo
            string[] automobiliuMasyvas = automobiliai.ToArray();
            Console.WriteLine(string.Join(" ", automobiliuMasyvas));

            List<int> elementai = new List<int> { 2, 25, 6, 42, 13 };
            Console.WriteLine($"Sandauga pirmo ir paskutinio elemento: {elementai[0] * elementai[4]}");

            List<string> vardai = new List<string> { "Jonas", "Petras", "Onute", "Zbignevas" };
            Console.WriteLine(string.Join(" ", vardai));

            vardai[3] = "Darius";
            Console.WriteLine(string.Join(" ", vardai));



        }

        static void Zodynai()
        {
            Dictionary<string, int> miestuZodynas = new Dictionary<string, int> // zodyno raktas visada yra pirmas kintamasis
            {
                {"Vilnius", 7 }, {"Kaunas", 10 }, {"Siauliai", 8 }, {"Jonava", 6 }
            };

            var vilnius = miestuZodynas["Vilnius"]; // irasoma Vilnius reiksme 7
            Console.WriteLine($"Vilnius reiksme = {vilnius}");

            miestuZodynas["Kaunas"] = 50;
            Console.WriteLine($"Kaunas reiksme = {miestuZodynas["Kaunas"]}");

            //UZDUOTIS//

            string[] menesiai = new string[6] { "Sausis", "Vasaris", "Kovas", "Balandis", "Geguze", "Birzelis" };

            Dictionary<string, int> menesis = new Dictionary<string, int>
            {
                {menesiai[0], menesiai[0].Length },
                {menesiai[1], menesiai[1].Length },
                {menesiai[2], menesiai[2].Length },
                {menesiai[3], menesiai[3].Length },
                {menesiai[4], menesiai[4].Length },
                {menesiai[5], menesiai[5].Length }
            };

            Console.WriteLine($"Pirmas menuo {menesiai[0]} ir jo raidziu skaicius {menesiai[0].Length}");
            Console.WriteLine($"Pirmas menuo {menesiai[1]} ir jo raidziu skaicius {menesiai[1].Length}");
            Console.WriteLine($"Pirmas menuo {menesiai[2]} ir jo raidziu skaicius {menesiai[2].Length}");
            Console.WriteLine($"Pirmas menuo {menesiai[3]} ir jo raidziu skaicius {menesiai[3].Length}");
            Console.WriteLine($"Pirmas menuo {menesiai[4]} ir jo raidziu skaicius {menesiai[4].Length}");
            Console.WriteLine($"Pirmas menuo {menesiai[5]} ir jo raidziu skaicius {menesiai[5].Length}");


        }

        enum DaysOfWeek { Sunday, Monday, Tuesday, WednesDay, Thursday, Friday, Saturday };

        enum DaysOfWeek1 { Sunday = 5, Monday = 4, Tuesday = 2, WednesDay = 1, Thursday = 3, Friday = 6, Saturday = 7 }; // galima priskirti indexa

        //UZDUOTIS 1

        public enum ELevel { Low , Medium , High  };

        static void Switch()
        {
            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 0:
                    Console.WriteLine($"{ELevel.Low} level");
                    break;
                case 1:
                    Console.WriteLine($"{ELevel.Medium} level");
                    break;
                case 2:
                    Console.WriteLine($"{ELevel.High} level");
                    break;
                default:
                    Console.WriteLine("Pasirinkimas neteisingas");
                    break;

            }           
        }

        public static void EnumTask2()
        {
            Console.WriteLine("Pasirinkite zinutes svarba 0 - low, 1 - medium, 2 - high");
            ELevel pasirinkimasEnum = Enum.Parse<ELevel>(Console.ReadKey().KeyChar.ToString());

            var zodynas = new Dictionary<ELevel, string>
            {
                { ELevel.Low, "Low level" },
                { ELevel.Medium, "Medium level" },
                { ELevel.High, "High level" }
            };
            Console.WriteLine(zodynas.ContainsKey(pasirinkimasEnum)? zodynas[pasirinkimasEnum] : "Neteisingas pasirinkimas");
        }

    }

}
