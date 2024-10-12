using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio14
    {
        public void Run()
        {
            Console.Write("Ingrese la distancia en metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());

            double kilometros = metros / 1000;
            double centimetros = metros * 100;
            double milimetros = metros * 1000;

            Console.WriteLine($"{metros} metros son {kilometros} km, {centimetros} cm y {milimetros} mm.");
        }
    }
}
