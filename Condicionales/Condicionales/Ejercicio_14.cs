using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_14
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su edad en años:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione su género:");
            Console.WriteLine("1. Femenino");
            Console.WriteLine("2. Masculino");
            int genero = int.Parse(Console.ReadLine());

            double pulsaciones;

            if (genero == 1) 
            {
                pulsaciones = (220 - edad) / 10.0;
            }
            else if (genero == 2)
            {
                pulsaciones = (210 - edad) / 10.0;
            }
            else
            {
                Console.WriteLine("Género no válido. Por favor seleccione 1 para Femenino o 2 para Masculino.");
                return;
            }

            Console.WriteLine($"El número de pulsaciones por cada 10 segundos de ejercicio es: {pulsaciones:F2}");
        }
    }
}
