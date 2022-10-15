using System;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int cantidad;
            float  PrecioArticulo, ValorVenta;
            string linea;

            Console.Write("Ingrese el valor del articulo:");
            linea = Console.ReadLine();
            PrecioArticulo = float.Parse(linea);
            Console.Write("Ingrese la cantidad de articulos a comprar por el cliente:");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);
            ValorVenta = PrecioArticulo * cantidad;
            Console.Write("El valor de la venta es:");
            Console.WriteLine(ValorVenta);
            Console.ReadKey();
        }
    }
}
