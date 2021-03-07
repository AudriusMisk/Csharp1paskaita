using System;

namespace P10_KondicinesSalygosSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 3;
            switch (menuChoice)
            {
                case 1: // kintamojo menuChoice reiksme
                    Console.WriteLine("Option 1");
                    break;
                case 2:
                    Console.WriteLine("Option 2");
                    break;
                case 3:
                    Console.WriteLine("Option 3"); // suveiks sis metodas
                    break;
                case 4:
                    Console.WriteLine("Option 4");
                    break;
                case 5:
                    Console.WriteLine("Option 5");
                    break;
                case 6:
                    Console.WriteLine("Option 6");
                    break;
                default:
                    Console.WriteLine("Pasirinkimas neteisingas"); // vykdoma jei nei 1 is case nesuveiks

            }


        }
    }
}
