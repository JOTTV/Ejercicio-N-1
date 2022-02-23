using System;

namespace Ejercicio_N_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOM;
            double Salario;
            int NHT, HET, HEE8;
            double VHN;
            Console.WriteLine("Ingresar Nombre");
            NOM = Console.ReadLine();
            Console.WriteLine("Ingresar Valor Hora Trabajada");
            VHN = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese # de horas trabajadas");
            NHT = Int32.Parse(Console.ReadLine());
            if (NHT > 40)
            {
                HET = (NHT - 40);
                if (HET>8)
                {
                    HEE8 = HET - 8;
                    Salario = (40 * VHN) + (16 * VHN) + HEE8 * 3 * VHN;
                }
                else
                {
                    Salario = 40 * VHN + HET * 2 * VHN;
                }
            }
            else
            {
                Salario = NHT * VHN;
            }
            Console.WriteLine("El Trabajador", NOM, "Devengo:", Salario);
        }
    }
}
