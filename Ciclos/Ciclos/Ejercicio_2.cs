using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Ejercicio_2
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 20; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los primeros 20 números naturales es: {suma}");
        }
    }
}
