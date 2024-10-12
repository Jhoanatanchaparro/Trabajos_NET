using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double cuadrado = numero * numero;
            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
        }
    }
}