using System;
using System.IO;
using System.Text;

namespace StringManipuliacijos
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Petras";
            string tuscia = "";
            string nulas = null;
            string baltaErdve = "    ";
            var netvarkingasTekstas = "  Kazkoks NEtvarkingAS Tekstas Su tarPais ir 155 0051 skaiciais ";

            // STRING CONSTRUCTOR //

            Console.WriteLine("String manipuliacijos");
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters); //string constructor metodu sukurtas stringas su charu masyvu
            Console.WriteLine(greetings);

            // STRING CONCATIONATION // egzistuoja bet nenaudoti !!!

            string pavarde = "Petraitis";
            string pilnasVardas = vardas + " " + pavarde; // galima prideti ne tik kintamuosius bet ir reiksme pvz: " "
            Console.WriteLine(pilnasVardas);

            // COMPOSITE FORMAT // geras budas bet sunkiau skaitosi nei interpoliacija

            DateTime siandien = DateTime.Today;
            var vardasIrData = string.Format("Vardas = {0} Siandienos data {1} ", vardas, siandien);
            Console.WriteLine(vardasIrData);

            // c$ - STRING INTERPOLATION // skaitomiausias budas

            var vardasPavardeIrData = $"Vardas = {vardas} Pavarde = {pavarde} Data = {siandien}";
            Console.WriteLine(vardasPavardeIrData);

            // STRING ILGIS //

            Console.WriteLine($"vardo ilgis {vardas.Length}");

            // STRING PALYGINIMAS //

            string galVardas = "petras";
            bool arVardaiLygus = vardas == galVardas;
            Console.WriteLine($"ar vardas {vardas} viduje lygus {galVardas}? {arVardaiLygus}");
            bool arVardaiLygus1 = vardas.Equals(galVardas, StringComparison.OrdinalIgnoreCase); // ignorina didziasias raides
            Console.WriteLine($"ar vardas {vardas} viduje lygus {galVardas} su Ignorecase: {arVardaiLygus1}");

            // STRING PAIESKA PRADZIOJE //

            Console.WriteLine($"ar vardas {vardas} prasideda 'Jon' {vardas.StartsWith("Jon")}");

            // STRING PAIESKA GALE //

            Console.WriteLine($"ar vardas {vardas} prasideda 'nas' {vardas.EndsWith("nas")}");

            // STRING PAIESKA CONTAINS //

            string etr = "etr";
            Console.WriteLine($"ar vardas {vardas} viduje turi {etr} ? {vardas.Contains(etr)}");

            // EMPTY STRINGS //

            bool arTuscia = string.IsNullOrEmpty(tuscia); // true
            bool arNullas = string.IsNullOrEmpty(nulas); // true
            bool arVardasTuscia = string.IsNullOrEmpty(vardas); //false
            bool arBaltaErdve = string.IsNullOrWhiteSpace(baltaErdve); //true   

            Console.WriteLine($"ar tuscia ? {arTuscia} | ar nulas? {arNullas} | ar balta erdve? {arBaltaErdve} | ar vardas tusicas? {arVardasTuscia}");

            // METODAS TRIM //

            Console.WriteLine($"tekstas su tarpais ({netvarkingasTekstas}).");
            Console.WriteLine($"tekstas su tarpais su isvalytais gale ir priekyje ({netvarkingasTekstas.Trim()}).");
            Console.WriteLine($"tekstas su tarpais su isvalytais priekyje ({netvarkingasTekstas.TrimStart()}).");
            Console.WriteLine($"tekstas su tarpais su isvalytais gale ({netvarkingasTekstas.TrimEnd()}).");

            // TEKSTAS MAZOSIOMIS AR DIDZIOSIOMIS //

            var tekstasDidziosiomisRaidemis = netvarkingasTekstas.ToUpper();
            Console.WriteLine($"tekstasSuTarpais didziosiomis ({tekstasDidziosiomisRaidemis})");
            var tekstasMazosiomisRaidemis = netvarkingasTekstas.ToLower();
            Console.WriteLine($"tekstasSuTarpais mazosiomis ({tekstasMazosiomisRaidemis})");

            // ESCAPE //

            string tekstas = "Donelaicio \"Metai\" ";
            Console.WriteLine(tekstas);
            Console.WriteLine(" jei reikia atspausdinti atvirkscia dalybos zenkla \\ "); // spausdina dalybos zenkla su escape
            Console.WriteLine(" jei reikia atspausdinti \n naujoje eiluteje "); // perkelia i kita eilute teksta ( geriau nenaudoti )
            Console.WriteLine($" jei reikia atspausdinti {Environment.NewLine} naujoje eiluteje  "); // perkelia i kita eilute teksta ( patartina naudoti )
            Console.WriteLine($" jei reikia atspausdinti {Path.DirectorySeparatorChar} katalogu atskyrimo simboli ");
            Console.WriteLine($" jei reikia atspausdinti figurinius skliaustus jei naudojame interpoliacija {{ }} ");

            string _varbatim = @" - jei reikia atspausdinti
viska taip
kaip
suvedame naudojam verbatim (@) identifikatoriu";
            Console.WriteLine(_varbatim);

            // SKAICIU PO KABLELIO RIBOJIMAS //

            double skaicius = 6.5292762754954366;
            var skaiciausTekstasSuRibojimu = skaicius.ToString("#.00");
            Console.WriteLine(skaiciausTekstasSuRibojimu);

            // STRING KEITIMAS I SKAICIU //
            var skaiciusString = "52"; // cia stringas o ne skaicius
            var budasNr1 = int.Parse(skaiciusString); //keitimas i skaiciu
            var budasNr2 = Convert.ToInt32(skaiciusString); // keitimas i skaiciu
            Console.WriteLine(budasNr1+budasNr2);

            // raidziu keitimas string viduje //

            var pakeistasTekstas = netvarkingasTekstas.Replace("a", "_");
            Console.WriteLine($"pakeistas tekstas{pakeistasTekstas}");

            // DALIES STRING NUSKAITYMAS //

            var dalisTeksto = netvarkingasTekstas.Substring(2, 10); // nuo 2 simbolio perskaityt  10 simboliu
            Console.WriteLine($"dalis teksto: {dalisTeksto}");

            // STRING BUILDER //

            StringBuilder sb = new StringBuilder("TEKSTAS");

            sb.Append("pridetas tekstas"); // prideda teksta prie sb kintamojo
            sb.AppendLine("pridedamas tekstas eiluteje");
            sb.Insert(5, "###"); // simboliu iterpimui bet kurioje vietoje naudojame .Insert(int, string)
            sb.Remove(1, 2);
            sb.Replace("zodis", "ZODIS"); // simboliu pakeitimui naudojame .Replace(string, string)
            var tekstasIsStringBuilder = sb.ToString();
            Console.WriteLine(tekstasIsStringBuilder);

            StringBuilder stringBuilder = new StringBuilder("");


            // TRY PARSE //

            string v1 = null;
            string v2 = "160519";
            string v3 = "9432.0";
            string v4 = "16,667";
            string v5 = "   -322     ";
            string v6 = " +4302";
            string v7 = "(100)";
            string v8 = "01FA";
            string v9 = "0x01FA";
            string v10 = "001";

            int number1;
            bool success1 = int.TryParse(v1, out number1);
            Console.WriteLine("Attempted conversion of '{0}'  . passed - {1} ({2})", v1, success1, number1);
            bool success2 = int.TryParse(v2, out int number2);
            Console.WriteLine("Attempted conversion of '{0}'  . passed - {1} ({2})", v2, success2, number2);



        }
    }
}
