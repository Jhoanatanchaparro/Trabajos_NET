using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Ejercicio_9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número para calcular su factorial:");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {num} es: {factorial}");
        }
    }
}
