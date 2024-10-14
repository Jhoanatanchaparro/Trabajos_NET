using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Ejercicio_3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el número de términos de la serie de Fibonacci:");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;

            Console.Write($"{a} {b} ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
        }
    }
}
