using System;

namespace Ejercicio_N_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double PDES;
            double ValComp = double.Parse(Console.ReadLine());
            string Color = (Console.ReadLine());
            if (Color == "Blanco")
            {
                PDES = 0;
            }
            else
            {
                if(Color=="Verde")
                {
                    PDES = 10;
                }
                else
                {
                    if (Color == "Amarillo")
                    {
                        PDES = 25;
                    }
                    else
                    {
                       if (Color == "Azul")
                        {
                            PDES = 50;
                        }
                        else
                        {
                            PDES = 100;
                        }
                    }
                }
            }
            Double ValPag = ValComp - PDES * ValComp / 100;
            Console.WriteLine("El Cliente Debe Pagar:$", ValPag);
        }
    }
}
