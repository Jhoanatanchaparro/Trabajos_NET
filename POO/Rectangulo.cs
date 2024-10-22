using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Rectangulo
    {
        public double Longitud { get; set; }
        public double Anchura { get; set; }

        public Rectangulo(double longitud, double anchura)
        {
            Longitud = longitud;
            Anchura = anchura;
        }


        public double CalcularArea()
        {
            return Longitud * Anchura;
        }

        public void Run()
        {
            Console.WriteLine($"Longitud: {Longitud}, Anchura: {Anchura}");
            Console.WriteLine($"Área del rectángulo: {CalcularArea()}");
        }
    }
}
