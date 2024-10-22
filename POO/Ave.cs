using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Ave
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        public Ave(string nombre, string color)
        {
            Nombre = nombre;
            Color = color;
        }

        // Método general para describir el canto del ave
        public virtual void Cantar()
        {
            Console.WriteLine($"{Nombre} está cantando.");
        }

        // Método general para volar
        public virtual void Volar()
        {
            Console.WriteLine($"{Nombre} está volando.");
        }

        // Clase hija: Canario
        public class Canario : Ave
        {
            public Canario(string color) : base("Canario", color)
            {
            }

            // Sobrescribir el método para describir el canto del canario
            public override void Cantar()
            {
                Console.WriteLine("El canario canta con un trino melodioso.");
            }
        }

        // Clase hija: Aguila
        public class Aguila : Ave
        {
            public Aguila(string color) : base("Águila", color)
            {
            }

            // Sobrescribir el método para volar, describiendo el vuelo del águila
            public override void Volar()
            {
                Console.WriteLine("El águila vuela alto y con majestuosidad.");
            }
        }

        // Clase hija: Pinguino
        public class Pinguino : Ave
        {
            public Pinguino(string color) : base("Pingüino", color)
            {
            }

            // Sobrescribir el método de volar porque los pingüinos no vuelan
            public override void Volar()
            {
                Console.WriteLine("El pingüino no puede volar, pero nada muy bien.");
            }
        }
    }
}
