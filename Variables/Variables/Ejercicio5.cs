using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio5
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double porcentaje = numero * 0.20;
            Console.WriteLine($"El 20% de {numero} es: {porcentaje}");
        }
    }
}
