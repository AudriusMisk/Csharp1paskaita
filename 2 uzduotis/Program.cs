using System;

namespace _2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
           float operacijosRezultatas = IveskDuSkaicius();
            Console.WriteLine($"Atsakymas: {operacijosRezultatas}");
        }

        static float IveskDuSkaicius()
        {
            Console.WriteLine("Iveskite 2 skaicius su kableliu");
            float skaiciusSuKableliu = float.Parse(Console.ReadLine());
            float antrasSkaiciusSuKableliu = float.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu pagal funkcija kuria norite atlikti: \n 1 - sudeti \n 2 - atimti \n 3" +
                " - padauginti \n 4 - padalinti \n 5 - pakelti suma kvadratu \n 6 - pakelti suma kubu");
            int menuChoice = int.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case 1: 
                    Console.WriteLine("Suma");
                    return skaiciusSuKableliu + antrasSkaiciusSuKableliu;
                case 2:
                    Console.WriteLine("Atimtis");
                    return skaiciusSuKableliu - antrasSkaiciusSuKableliu;
                case 3:
                    Console.WriteLine("Daugyba");
                    return skaiciusSuKableliu * antrasSkaiciusSuKableliu;
                case 4:
                    Console.WriteLine("Dalyba");
                    return skaiciusSuKableliu / antrasSkaiciusSuKableliu;
                case 5:
                    Console.WriteLine("Kvadratine suma");
                    return (skaiciusSuKableliu + antrasSkaiciusSuKableliu) * (skaiciusSuKableliu + antrasSkaiciusSuKableliu);
                case 6:
                    Console.WriteLine("Kubine suma");
                    return (skaiciusSuKableliu + antrasSkaiciusSuKableliu) * (skaiciusSuKableliu + antrasSkaiciusSuKableliu) * (skaiciusSuKableliu + antrasSkaiciusSuKableliu);
                default:
                    Console.WriteLine("Pasirinkimas neteisingas");
                    return 0F;
            }
        }
    }
}
