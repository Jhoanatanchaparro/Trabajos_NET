using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio13
    {
        public void Run()
        {
            Console.Write("Ingrese el tiempo en segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());

            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;

            Console.WriteLine($"El tiempo es {horas} horas y {minutos} minutos");
        }
    }
}
