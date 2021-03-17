using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomething(2);
        }

        static void DoSomething(int y = 3, int x, int z = 4)
        {
            Console.WriteLine($"{x}{y}{z}");
        }
    }
}
