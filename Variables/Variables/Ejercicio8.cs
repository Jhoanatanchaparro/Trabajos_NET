using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio8
    {
        public void Run()
        {
            double suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                suma += Convert.ToDouble(Console.ReadLine());
            }

            double promedio = suma / 5;
            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}
