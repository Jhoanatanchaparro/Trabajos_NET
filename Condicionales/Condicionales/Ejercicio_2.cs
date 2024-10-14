using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_2
    {
        public void Run()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0 || edad > 100)
            {
                Console.WriteLine("Por favor, ingrese una edad válida.");
            }
            else if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad.");
            }
        }
    }
}
