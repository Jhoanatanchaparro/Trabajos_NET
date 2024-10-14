using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Ejercicio_4
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                suma += num;
            }
            double promedio = suma / 10.0;
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
