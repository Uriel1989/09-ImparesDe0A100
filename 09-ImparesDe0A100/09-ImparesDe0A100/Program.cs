using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_ImparesDe0A100
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a;
            a = 0;
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    a = a + 1;
                    Console.WriteLine("Los numeros impares son: " + i);
                }
            }
            Console.WriteLine("La cantidad de numeros impares es de: " + a);
            Console.ReadKey();
        }
    }
}
