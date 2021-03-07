using System;

namespace P09_NaudotojoIvestis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paspauskite bet ka");
            char userCharEntered = Console.ReadKey().KeyChar; // nuskaito pirma ivesta simboli be enter
            Console.WriteLine($" ivesta {userCharEntered}");

           // var userCharEntered1 = Console.Read(); // nuskaito pirma ivesta simboli paspaudus enter

            string whatUserEntered = Console.ReadLine(); // nuskaito viska kas irasyta i ekrana
            Console.WriteLine($"\n naudotojas ivede: {whatUserEntered}");


            Console.WriteLine("iveskite skaiciu");
            int skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine($"naudotojas ivede skaiciu{skaicius}");



        }

    }
}
