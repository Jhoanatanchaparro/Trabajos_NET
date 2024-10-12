using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ejercicio10
    {
        public void Run()
        {
            Console.Write("Ingrese el salario diario: ");
            double salarioDiario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese los días trabajados: ");
            int diasTrabajados = Convert.ToInt32(Console.ReadLine());

            double salarioBruto = salarioDiario * diasTrabajados;
            double pension = salarioBruto * 0.10;
            double salud = salarioBruto * 0.15;
            double salarioNeto = salarioBruto - (pension + salud);

            Console.WriteLine($"El salario neto a pagar es: {salarioNeto}");
        }
    }
}
