using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_13
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su peso en kilogramos (kg):");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura en metros (m):");
            double estatura = double.Parse(Console.ReadLine());

            // Cálculo del IMC
            double imc = peso / (estatura * estatura);

            // Determinación del estado de salud basado en el IMC
            string estado;
            if (imc < 18.5)
            {
                estado = "Desnutrido";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                estado = "Normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                estado = "Sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                estado = "Obesidad Grado 1";
            }
            else if (imc >= 35 && imc < 40)
            {
                estado = "Obesidad Grado 2";
            }
            else if (imc >= 40 && imc < 50)
            {
                estado = "Obesidad Grado 3";
            }
            else
            {
                estado = "Obesidad Grado 4";
            }

            // Mostrar el resultado
            Console.WriteLine($"Su IMC es: {imc:F2}");
            Console.WriteLine($"Estado de salud: {estado}");
        }
    }
}
