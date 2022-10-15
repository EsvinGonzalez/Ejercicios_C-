using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, z, suma;
            Console.Write("Ingresa el valor de x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de z: ");
            z = double.Parse(Console.ReadLine());
            suma=x+z;
            if(suma>0)
                Console.WriteLine("la suma S\u00CD es mayor que cero.");
            else
                Console.WriteLine("la suma no es mayor que cero.");
            Console.WriteLine("Valor de suma: " + suma);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
