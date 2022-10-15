using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int x = 8; x <= 500; x++)
            {
              if ((x % 8 == 0) && (x % 1 == 0))
                Console.Write("{0} ", x);
            }
        }
    }
}
