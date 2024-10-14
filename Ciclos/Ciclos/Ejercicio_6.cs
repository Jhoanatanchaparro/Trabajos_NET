using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Ejercicio_6
    {
        public void Run()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            for (int i = n - 1; i >= 1; i--)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
