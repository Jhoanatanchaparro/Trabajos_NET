using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio_3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese la velocidad en km/h: ");
            double velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tiempo en horas: ");
            double tiempo = Convert.ToDouble(Console.ReadLine());

            double distancia = velocidad * tiempo;
            Console.WriteLine($"La distancia recorrida es: {distancia} km");
        }

    }
}
