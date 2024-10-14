using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_10
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el número de llantas a comprar:");
            int llantas = int.Parse(Console.ReadLine());
            int precioUnitario;

            if (llantas < 6)
            {
                precioUnitario = 240000;
            }
            else if (llantas == 6 || llantas == 7)
            {
                precioUnitario = 221000;
            }
            else
            {
                precioUnitario = 180000;
            }

            int total = llantas * precioUnitario;
            Console.WriteLine($"El valor total a pagar es: ${total}");
        }
    }
}