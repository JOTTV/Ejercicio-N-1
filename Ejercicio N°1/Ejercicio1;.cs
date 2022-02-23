using System;

class TestClass
{
    static void Main(string[] args)
    {
        int a,b;
        Console.WriteLine("Ingrese el valor de a: ");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de b: ");
        b = Int32.Parse(Console.ReadLine());
        if(a>b){
            Console.WriteLine("a es mayor que b ");
        }
        else if(a = b){
            Console.WriteLine("a es igual que b ");
        }
        else{
            Console.WriteLine("a es menor que b ");
        }
    }
}