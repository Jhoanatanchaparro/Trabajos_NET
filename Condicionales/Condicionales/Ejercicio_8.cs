using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_8
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int num3 = int.Parse(Console.ReadLine());

            int[] numeros = { num1, num2, num3 };
            Array.Sort(numeros);

            Console.WriteLine("Orden Ascendente:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Array.Reverse(numeros);
            Console.WriteLine("Orden Descendente:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
