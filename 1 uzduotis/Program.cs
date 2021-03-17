using System;

namespace _1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacijuRezultatas = TrysSkaiciai();
            Console.WriteLine($"Jusu atsakymas : {operacijuRezultatas}");
        }

        static int TrysSkaiciai()
        {
            Console.WriteLine(" Iveskite 3 skaicius");
            int pirmasSk = int.Parse(Console.ReadLine());
            int antrasSk = int.Parse(Console.ReadLine());
            int treciasSk = int.Parse(Console.ReadLine());

            Console.WriteLine($"Pasirinkite viena is 3 skaiciu: {pirmasSk}, {antrasSk}, {treciasSk}");
            int pasirinktasSkaicius = int.Parse(Console.ReadLine());


            
            Console.WriteLine("Pasirinkite skaiciu pagal operacija kuria norite atlikti:\n 1 - sudeti \n 2 - atimti \n 3 - padauginti \n 4 - padalinti");
            int operacijosSkaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite dar viena skaiciu");
            int antrasSkaicius = int.Parse(Console.ReadLine());

            if (operacijosSkaicius == 1)
            {
                return pasirinktasSkaicius + antrasSkaicius;
            }

            else if (operacijosSkaicius == 2)
            {
                return antrasSkaicius - pasirinktasSkaicius;
            }
            else if (operacijosSkaicius == 3)
            {
                return pasirinktasSkaicius * antrasSkaicius;
            }
            else if (operacijosSkaicius == 4)
            {
                return pasirinktasSkaicius / antrasSkaicius;
            }
            else
            {
                Console.WriteLine("Ivestas operacijos skaicius yra blogas");
                return 0;
            }
        }
    }
}
