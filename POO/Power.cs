using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Power
    {
        public double Pow(double x, int n)
        {
            return Math.Pow(x, n);
        }
        public void Run(double x, int n)
        {
            Console.WriteLine($"Base: {x}, Exponente: {n}");
            Console.WriteLine($"Resultado de {x}^{n}: {Pow(x, n)}");
        }
    }
}
