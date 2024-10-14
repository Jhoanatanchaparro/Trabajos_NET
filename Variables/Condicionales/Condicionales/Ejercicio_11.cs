using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_11
    {
        public void Run()
        {
            Console.WriteLine("Seleccione el tamaño de la pizza (1, 2, 3):");
            int tamaño = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de ingredientes adicionales:");
            int ingredientesAdicionales = int.Parse(Console.ReadLine());

            int precioBase;
            switch (tamaño)
            {
                case 1:
                    precioBase = 15000;
                    break;
                case 2:
                    precioBase = 24000;
                    break;
                case 3:
                    precioBase = 36000;
                    break;
                default:
                    Console.WriteLine("Tamaño inválido.");
                    return;
            }

            int precioTotal = precioBase + (ingredientesAdicionales * 4000);
            Console.WriteLine($"El precio total a pagar es: ${precioTotal}");
        }
    }
}
