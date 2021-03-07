using System;

namespace P5_LoginiaiOperatoriai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loginiai operatoriai && || !");
            bool tiesa = true;
            bool melas = !tiesa;

            Console.WriteLine($"Neigimas {melas}");

            Console.WriteLine($"IR (&&)");
            Console.WriteLine($" tiesa && melas {tiesa && melas}");
            Console.WriteLine($" tiesa && tiesa {tiesa && tiesa}");
            Console.WriteLine($" melas && melas {melas && melas}");

            Console.WriteLine($"ARBA (||)");
            Console.WriteLine($" tiesa || melas {tiesa || melas}");
            Console.WriteLine($" tiesa || tiesa {tiesa || tiesa}");
            Console.WriteLine($" melas || melas {melas || melas}");

            // loginiai operatoriai visada sugrazina boolean(true/false)

            Console.WriteLine("-----Press any key to continue----------");
            Console.ReadKey();
        }
    }
}