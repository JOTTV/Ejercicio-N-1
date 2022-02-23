    using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int VD1=0,VD2=0,VD3=0,SALAR=0,TOTVEN=0,PORVEN=0;
            int v = VD1 + VD2 + VD3;
            TOTVEN = v;
            PORVEN = ((int)(0.33 * TOTVEN));
            int SALAR1,SALAR2,SALAR3;
           
            if (VD1 > PORVEN)
            {
                SALAR1 = (int)(SALAR + (0.2 * SALAR));
            }
            else 
            {
                SALAR1 = SALAR;
            }
            if (VD2 > PORVEN)
            {
                SALAR2 = (int)(SALAR + (0.2 * SALAR));
            }
            else
            {
                SALAR2 = SALAR;
            }
            if (VD3 > PORVEN)
            {
                SALAR3 = (int)(SALAR + (0.2 * SALAR));
            }
            else
            {
                SALAR3 = SALAR;
            }
            Console.WriteLine("SALARIO VENDEDORES DEPTO.1" + SALAR1);

            Console.WriteLine("SALARIO VENDEDORES DEPTO.2" + SALAR2);

            Console.WriteLine("SALARIO VENDEDORES DEPTO.3" + SALAR3);


        }
    }
}
