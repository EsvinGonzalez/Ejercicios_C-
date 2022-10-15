using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double antiguedad, aumento, sueldo, sueldo_a_pagar;
            Console.Write("Ingresa el valor de antiguedad: ");
            antiguedad = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de sueldo: ");
            sueldo = double.Parse(Console.ReadLine());
            aumento=0;
            if(sueldo<500&&antiguedad>=10)
                aumento=sueldo*0.2;
            if(sueldo<500&&antiguedad<10)
                aumento=sueldo*0.05;
            sueldo_a_pagar=sueldo+aumento;
            Console.WriteLine("Valor de aumento: " + aumento);
            Console.WriteLine("Valor de sueldo a pagar: " + sueldo_a_pagar);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
