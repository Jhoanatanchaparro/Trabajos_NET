using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio6
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double porcentaje30 = numero * 0.30;
            double porcentaje60 = numero * 0.60;
            double porcentaje90 = numero * 0.90;

            Console.WriteLine($"El 30% es {porcentaje30}, el 60% es {porcentaje60}, el 90% es {porcentaje90}");
        }
    }
}