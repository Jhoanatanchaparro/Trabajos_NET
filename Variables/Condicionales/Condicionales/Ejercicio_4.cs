using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_4
    {
        public void Run()
        {
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"El mayor es {numero1} y el menor es {numero2}.");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El mayor es {numero2} y el menor es {numero1}.");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
    }
}