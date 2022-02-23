using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 Y = 20, A = 10, B = 5, C = 2;
            if (Y<A && ((A<B)&&(B<C)))
            {
                Console.Write("X=0");
            }
            else
            {
                if ((A<=Y)&&(Y<B))
                {
                    Console.Write("X=1");
                }
                else
                {
                    if ((B<=Y)&&(Y<C))
                    {
                        Console.Write("X=2");
                    }
                    else
                    {
                        if (C<=Y)
                        {
                            Console.Write("X=3");
                        }
                        else
                        {
                            Console.Write("X=4");
                        }
                    }
                }
                
            }
        }
    }
}
