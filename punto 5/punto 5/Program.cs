using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, m;
            Console.WriteLine("ingrese el primer numero ");
             n1 =Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero ");
            n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero ");
            n3 = Int32.Parse(Console.ReadLine());

            if((n1 > n2) && (n1 > n3))
            {
                m = n1;
            }
            else
            {
              if( n2 > n3)
                {
                    m = n2;
                }
              else
                {
                    m = n3;
                }
            }

            Console.WriteLine("el valor mayor entre:  " + n1 + "," + n2 + "," + n3 + " es" + m);
            Console.ReadKey();




        }
    }
}
