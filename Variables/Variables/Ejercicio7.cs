using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio7
    {
        public void Run()
        {
            Console.Write("Ingrese la longitud del lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            double area = lado * lado;
            Console.WriteLine($"El área del cuadrado es: {area}");
        }
    }
}
