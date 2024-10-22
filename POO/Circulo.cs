using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public void Run()
        {
            Console.WriteLine($"Radio: {Radio}");
            Console.WriteLine($"Área del círculo: {CalcularArea()}");
            Console.WriteLine($"Perímetro del círculo: {CalcularPerimetro()}");
        }
    }
}
