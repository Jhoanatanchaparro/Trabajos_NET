using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el valor de la cuenta:");
            double cuenta = double.Parse(Console.ReadLine());

            if (cuenta < 150000)
            {
                Console.WriteLine("Pago en efectivo.");
            }
            else if (cuenta >= 150000 && cuenta <= 300000)
            {
                Console.WriteLine("Pago con el celular (dinero electrónico).");
            }
            else if (cuenta > 300000 && cuenta <= 600000)
            {
                Console.WriteLine("Pago con la tarjeta de débito.");
            }
            else
            {
                Console.WriteLine("Pago con la tarjeta de crédito.");
            }
        }
    }
}
