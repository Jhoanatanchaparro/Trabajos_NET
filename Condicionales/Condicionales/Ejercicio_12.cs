using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_12
    {
        public void Run()
        {
            Console.WriteLine("Ingrese la cantidad de artículos:");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio unitario del artículo:");
            double precioUnitario = double.Parse(Console.ReadLine());

            double descuento = 0;

            if (cantidad > 5 && cantidad < 10)
            {
                descuento = 0.05;
            }
            else if (cantidad >= 10)
            {
                descuento = 0.08;
            }

            double precioConDescuento = precioUnitario * (1 - descuento);
            double total = cantidad * precioConDescuento;

            Console.WriteLine($"El precio total a pagar es: ${total}");
        }
    }
}
