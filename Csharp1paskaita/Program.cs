using System;
using System.Collections.Generic;

namespace Csharp1paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas vakras!");

            Console.WriteLine("Išvedimas per {0}","kompozicija" ,"ekrana" );
            Console.WriteLine($"Isvedimas {"per"} interpoliacija");

            Console.WriteLine("Audrius");

            byte mazasSkaicius = 2; //8 bitu integeris, max value 255
            short trumpasSkaicius = 2; // 16 bitu integeris 32767 max
            int skaicius = 2; // 32 bitu integeris
            int maksimalusIntSkaicius = int.MaxValue;
            int minimalusIntSkaicius = int.MinValue;

            uint maksimalusUintSkaicius = uint.MaxValue;

            Nullable<int> skaiciusGalintisButiNull = null; //kaip aprasyti null
            int? nullSkaicius = null; // paprastesnis Nullable<int> uzrasymas

            long ilgasSkaicius = 10;

            Console.WriteLine("Floating point");

            float fSkaicius = 8.4215213F; // nepamirsti gale parasyti suffixo F
            double dblSkaicius = 8.6456475; // suffixo nereikia, dvigubai didesnis uz double
            decimal dcmSkaicius = 8.5234234M; // reikia suffixo M, dar didesnis uz double
            Console.WriteLine("PROBLEMOS SU TIKSLUMU");
            float f1 = 0.09f * 100f;
            float f2 = 0.09f * 99.999999f;
            Console.WriteLine("ar f1 > f2? {0}", f1 > f2); 
            Console.WriteLine("ar f1 > f2? {0}", f1 < f2);
            Console.WriteLine("ar f1 > f2? {0}", f1 == f2); // rodo jog F1 = F2

            Console.WriteLine("ar float 0.99F == 1? {0}", 0.99F == 1);
            Console.WriteLine("ar float 0.999999F == 1? {0}", 0.999999F == 1);
            Console.WriteLine("ar double 0.99999999 == 1? {0}", 0.99999999 == 1);
            Console.WriteLine("ar double 0.99999999999999999 == 1? {0}", 0.99999999999999999 == 1);
            Console.WriteLine("ar decimal 0.99999999999999999 == 1? {0}", 0.99999999999999999M == 1);

            double avogadroSkaicius = 6.022e23; // skaicius kuris yra 6.022 * 10^23
            double skaiciusSuTarpais = 522_1_000_0.00_01; // tarpai skirti palengvinti dideliu skaiciu skaityma

            int trylika = 0b00001101;// 13 binariniu (0b) budu
            int duSimtaiPenkiasdesimt = 0xFA; // 250 sesioliktainis (0x) budu

            //Daugybinė kintamųjų deklaracija
            int dDeklaracija1, dDeklaracija2, dDeklaracija3, dDeklaracija4;
            dDeklaracija1 = dDeklaracija2 = dDeklaracija3 = dDeklaracija4 = 100; // Visiems priskiriama reiksme 100


            //loginis kintamasis
            bool teisybe = true;
            bool neteisybe = false;

            //Char kintamasis (išsaugo 1 simbolį)
            char raide= 'n';
            char.IsDigit(raide);
            char.IsLetter(raide);
            char.IsLetterOrDigit(raide);

            //Data ir laikas kintamieji

            DateTime siandien = DateTime.Now; // siandienos data ir laikas
            DateTime kazkokiaData = new DateTime(2000, 1, 1);

            //String duomenu tipas talpinantis teksta

            string vardas = "Petras";
            string tuscia = ""; // tuscias bet ne null
            string stringNullas = null; // string nullas
            string baltaErdve = "      "; // stringo whitespace

            //implicit "type" var, Type Interface // var automatiskai priskiria kintamojo tipa
            var nulis = 0;
            var kazkoksTekstas = "kazkoks tekstas";

            //kintamuju tipu keitimas
            Console.WriteLine("Skaičių tipų keitimas");
            // byte - short, int, long, double : all numeri types
            // short - int, long, float, double : can not convert into byte as it is smaller container.
            // int - long, float, double : same reason as above.
            // long - float, double : same reason as above.
            // float double, decimal : same reason as above.
            // char - int, long, float, double ...


            int skaiciusInt = 100;
            long skaiciusLong = 100;

            //*** implicit type casting
            long castintasLong = (long)skaiciusInt;
            long castintasLong1 = skaiciusInt; // maziau skaitomas bet validi castinimo versija

            int castintasInt = (int)skaiciusLong; // skliausteliai sioje vietoje jau butini

            long skaiciusLongDidesnis = 3_000_000_000;
            int skaiciusIntDidelis = (int)skaiciusLongDidesnis;
            Console.WriteLine($"skaiciusIntDidelis = {skaiciusIntDidelis}"); // kadangi int netalpina tokio skaiciaus isspausdina bloga atsakyma

            //*** skaiciaus vertimas i teksta
            var tekstasIsSkaicius = skaiciusLongDidesnis.ToString();

            //*** explicit conversion
            int castintasInt1 = int.Parse(skaiciusLong.ToString());
            // int castintasInt2 = int.Parse(skaiciusLongDidesnis.ToString()); //Luzta nes netalpina

            //*** convert
            long castingasLong2 = Convert.ToInt64(skaiciusInt);
            //int castintasInt3 = Convert.ToInt32(skaiciusLongDidesnis); LUZTA NES NETALPINA

            //*** darbas su nullable kintamaisiais
            int? skaiciusIntNull = null;
            //  long castintasLong3 = (long)skaiciusIntNull; // LUZTA implicit cast negali dirbti su null
            long castintasLong4 = Convert.ToInt64(skaiciusIntNull); // grazina default t.y. 0

            //--------------
            KeyValuePair<int, string> raktasIrReiksme = new KeyValuePair<int, string>(10, "Laptop"); // KVP talpina 2 bet kokius tipus

            Tuple<int, int, string> tuple = new Tuple<int, int, string>(10, 100, "Laptop"); // talpina iki 7 bet kokiu tipu
            Tuple<int, int, string, string> tuple1 = new Tuple<int, int, string, string>(10, 100, "Laptop", "Lenovo");

            Console.WriteLine("C# kintamuju taisykles:");
            // Taisykle 1. Kiekvienas kintamasis turi prasideti mazaja (a-z) arba didziaja (A-Z) raider arba underscore (_)
            int kintamasis = 1;
            int Kintamasis = 1;
            int _kintamasis = 1;
            // Taisykle 2. Kintamoji pavadinimas turi aprasyti tai kas jis yra (nurodyti savo paskirti)
            int score = 1; //bet ne s
            int playerScore = 1; //bet ne ps
            // Taisykle 3. Trumpinimu arba raidziu pametinejimu reiktu vengti.
            string playerName = "Jonas"; //bet ne plyrnm
            // Taisykle 4. Prefiksu ir postfiksu reiketu vengti pvz player bet ne strPlayer.
            string player = "Jonas"; //bet ne strPlayer
            // Taisykle 5. Geriau ilgesni ir aiskesni kintamieji nei raidziu taupymas.
            // Taisykle 6. Jei kintamasis baigiasi skaiciu, reikia turbut geresnio pavadinimo.
            // Taisykle 7. Zodziai data,text,number,item duoda mazai informacijos.
            // Taisykle 8. kintamiesiems naudojam zodziu atskyrima.
            int PascalCaseKintamasis = 1;
            int camelCaseKintamasis = 1;
            int snake_case_kintamasis = 1;

            Console.WriteLine("Duomenu istraukimas is kintamuju");

          


            Console.ReadKey();
            Console.Clear();
        }
    }
}
