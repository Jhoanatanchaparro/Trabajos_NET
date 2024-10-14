using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_5
    {
        public void Run()
        {
            double sumaNotas = 0.0;
            int cantidadNotas = 5;

            for (int i = 1; i <= cantidadNotas; i++)
            {
                Console.Write($"Ingrese la nota {i} (0.0 a 5.0): ");
                double nota = double.Parse(Console.ReadLine());

                
                while (nota < 0.0 || nota > 5.0)
                {
                    Console.WriteLine("Por favor, ingrese una nota válida.");
                    Console.Write($"Ingrese la nota {i} (0.0 a 5.0): ");
                    nota = double.Parse(Console.ReadLine());
                }

                sumaNotas += nota;
            }

            double promedio = sumaNotas / cantidadNotas;

            Console.WriteLine($"El promedio es: {promedio}");

            if (promedio >= 3.0)
            {
                Console.WriteLine("Aprobó");
            }
            else
            {
                Console.WriteLine("No aprobó");
            }
        }
    }
}
