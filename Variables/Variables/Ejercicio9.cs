using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio9
    {
        public void Run()
        {
            Console.Write("Ingrese el valor unitario del producto: ");
            double valorUnitario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad de productos comprados: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            double subtotal = valorUnitario * cantidad;
            double total = subtotal * 1.16; // Incluye el 16% de IVA
            Console.WriteLine($"El valor total a pagar es: {total}");
        }
    }
}
