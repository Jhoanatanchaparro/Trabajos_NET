using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio4
    {
        public void Run()
        {
            Console.Write("Ingrese el año actual: ");
            int año_actual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su año de nacimiento: ");
            int año_nacimiento = Convert.ToInt32(Console.ReadLine());

            int edad = año_actual - año_nacimiento;
            Console.WriteLine($"Tienes {edad} años.");
        }
    }
}
