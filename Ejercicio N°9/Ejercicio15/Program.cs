using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoA=0 , pesoB=0 , pesoC=0 , pesoD=0  ;
            if ((pesoA == pesoB) && (pesoA == pesoC))
            {
                if(pesoD > pesoA)
                {
                    Console.WriteLine("La esfera D es la diferente y");
                }
                else
                {
                    Console.WriteLine("La esfera D es la diferente y");
                }

            }
            else
            {
                if ((pesoA == pesoB) && (pesoA == pesoD))
                {
                    Console.WriteLine("La esfera C es la diferente");
                    if (pesoC > pesoA)
                    {
                        Console.WriteLine("y es de mayor peso");
                        
                    }
                    else
                    {
                        Console.WriteLine("y es de menor peso");
                    }


                }
                else
                {
                    if((pesoA == pesoC) && (pesoA == pesoD))
                    {
                        Console.WriteLine("La esfera B es la diferente");
                        if (pesoB > pesoD)
                        {
                            Console.WriteLine("y es de mayor peso");

                        }
                        else
                        {
                            Console.WriteLine("y es de mayor peso");
                        }

                    }
                    else
                    {
                        Console.WriteLine("La esfera A es la Diferente");
                        if (pesoA > pesoB)
                        {
                            Console.WriteLine("y es de mayor peso");

                        }
                        else
                        {
                            Console.WriteLine("y es de menor peso");
                        }
                    }


                    
                }
            }
        }
    }
}
