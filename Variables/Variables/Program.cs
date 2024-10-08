using System;
namespace ProyectoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 19;
            float temperatura = 36.5f;
            double precio = 49.99;
            char inicial = 'J';
            string nombreCompleto = "Jhonatan Chaparro";
            bool esMayorDeEdad = true;

            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Temperatura: {temperatura}");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"inicial: {inicial}");
            Console.WriteLine($"Nombre Completo: {nombreCompleto}");
            Console.WriteLine($"Es Mayor de Edad: {esMayorDeEdad}");
        }
    }
}