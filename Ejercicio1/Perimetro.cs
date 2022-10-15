using System;

namespace perimetro
{
    class perimetro
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;
            Console.WriteLine("ingrese el lado del cuadrado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("el perimetro del cuadrado es:");
            Console.Write(perimetro);
            Console.ReadKey();

        }
    }
}
