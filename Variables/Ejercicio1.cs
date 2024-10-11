using System;

namespace Variables
{
    internal class Ejercicio1
    {
        // Método Run que será llamado desde la clase Program
        public void Run()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 * num2 * num3;
            Console.WriteLine($"El resultado de la multiplicacion es : {resultado}");
        }
    }
}

