using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio12
    {
        public void Run()
        {
            Console.Write("Ingrese la longitud del primer cateto: ");
            double cateto1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del segundo cateto: ");
            double cateto2 = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));
            Console.WriteLine($"La hipotenusa es: {hipotenusa}");
        }
    }
}
