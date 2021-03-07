using System;

namespace P2_Komentarai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Komentarai ***");
            Console.WriteLine("1 Kokie būna komentarai?");
            // čia paprastas komentaras

            /* 
             čia 
             multi-line
             komentaras
            */


            //cia komentaras pries programine eilute
            int skaicius = 0;
            var komentaras = /*komentadas*/ "galima taip";
            Console.WriteLine($"čia komentaras {komentaras}"); // komentaras gali būti čia

            Console.WriteLine("2 Kodėl rašyti komentarus?");

            Console.WriteLine("3 Kaip rašyti gerus komentarus?");
            /*1. rašyti komentarus kodo gabalui kuris funkciškai yra išbaigtas
              2. rašyti komentarus kurie prideda kodui prasmės, o ne tiesiog pasako ką kodas daro
                 Štai blogas komentavimo pavyzdys:
            */
            //Console.WriteLine naudojamas į ekraną išvesti Hello World!
            Console.WriteLine("Hello World!");
            /*
           Juk ir taip aišku ką daro kodas.. išmokime skaityti kodą
           Štai geresnis komentaras:
          */

            //Išvesti Hello World! tai mano pirmoji veikianti programa. 
            Console.WriteLine("Hello World!");
            /*Toks komentaras man atsako į klauimą kodėl yra šita kodo eilutė, o ne ką ji daro 
               3. Nebūtina komentuoti kiekvieną kodo eilutę. Per daug komentuotas kodas yra toks pat blogas kaip ir visai nekomentuotas kodas.
               4. Kai komentuojate kodą įjunkite empatiją, pagalvokite ką kitas programuotojas ar jūs pats atityje norėsite šinoti apie kodą
               5. Daug komentarų nepagerina blogai parašytą kodą. 
              Naudojantis gera kodo rašimo kultūra komentarų poreikis labai mažėja o dažnai ir apskirtai išnyksta. 
              Pirmiausia reikia rašyti kaip įmanoma skaitomesnį kodą, o tada tik komentuoti tas vietas kurios nėra visiškai aiškios arba paaiškina didesnį kodo paveikslą.
             */

            Console.WriteLine("-- !!! SVARBI !!! UŽDUOTIS--");
            Console.WriteLine("1. Komentuokite VISKĄ ką programuosite. Kiekvieną kodo dalį, smulkmeną. Ką kodas daro ir kodėl. Ką suprantate ir kokie klausimai kyla. ");
            Console.WriteLine("   Tai nėra prasminga, tačiau tai padės geriau išmokti programuoti");
            Console.WriteLine("   Nustoti komentuoti viską galėsite tik tada, ka baigsime pradmenų dalį");



            Console.WriteLine("-----Press any key to continue----------");
            Console.ReadKey();
        }
    }
}