using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ni = 0, Pat = 0, Es = 0;
            double PagMat=50000;
            string Nom;
            Console.WriteLine("Introduzca el numero de inscripcion ");
            Ni = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre ");
            Nom = Console.ReadLine();
            Console.WriteLine("Introduzca el patrimonio ");
            Pat = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el estrato social ");
            Es = Int32.Parse(Console.ReadLine());

    
            if (Pat > 2000000 && Es > 3)
            {
                PagMat = PagMat + 0.03 * Pat;
            }

            Console.WriteLine("El estudiante con numero de inscripcion" + Ni
                + "y nombre " + Nom + "debe pagar: $ " + PagMat);
           // Console.ReadKey();
        }
    }
}
