using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio11
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double raiz = Math.Pow(numero, 0.5);  // Usando exponenciación
            Console.WriteLine($"La raíz cuadrada de {numero} es: {raiz}");
        }
    }
}
