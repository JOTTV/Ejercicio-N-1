using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean A = true, B = true, C = true, D = false, E = false;
            if (A)
            {
                if (B)
                {
                    Console.WriteLine("Secuanecia 1");
                }
                else
                {
                    if (C)
                    {
                        Console.WriteLine("Secuanecia 2");
                    }
                    else
                    {
                        Console.WriteLine("Secuanecia 3");
                    }
                }
            }
            else
            {
                Console.WriteLine("Secuanecia 4");
            }
            if (D)
            {
                if (E)
                {
                    Console.WriteLine("Secuanecia 5");
                }
                else
                {
                    Console.WriteLine("Secuanecia 6");
                }
            }
            else
            {
                Console.WriteLine("Secuanecia 7");
            }
        }
    }
}
