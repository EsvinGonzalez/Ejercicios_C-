using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            string linea;

            Console.Write("Ingrese un numero entero que tenga uno o dos digitos:");
            linea = Console.ReadLine();
            n1 = int.Parse(linea);
            if (n1<10)
                {

                    Console.WriteLine("El numero tiene un digito");
               
                }
            else
                {

                Console.WriteLine("El numero tiene dos digitos");

                }
             
                    Console.ReadKey();
        }
    }
}
