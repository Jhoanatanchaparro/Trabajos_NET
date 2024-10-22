using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Vehiculo
    {
        public string Placa { get; set; }

        public Vehiculo(string placa)
        {
            Placa = placa;
        }

        public bool TieneRestriccion()
        {
            int ultimoDigito = int.Parse(Placa[^1].ToString());
            DayOfWeek diaSemana = DateTime.Now.DayOfWeek;

            var restriccion = new Dictionary<DayOfWeek, int[]>
            {
                { DayOfWeek.Monday, new int[] { 1, 2 } },  // Lunes: placas terminadas en 1, 2
                { DayOfWeek.Tuesday, new int[] { 3, 4 } }, // Martes: placas terminadas en 3, 4
                { DayOfWeek.Wednesday, new int[] { 5, 6 } }, // Miércoles: placas terminadas en 5, 6
                { DayOfWeek.Thursday, new int[] { 7, 8 } }, // Jueves: placas terminadas en 7, 8
                { DayOfWeek.Friday, new int[] { 9, 0 } }   // Viernes: placas terminadas en 9, 0
            };

            if (restriccion.ContainsKey(diaSemana) && Array.Exists(restriccion[diaSemana], d => d == ultimoDigito))
            {
                return true;
            }
            return false;
        }

        public void Run()
        {
            Console.WriteLine($"Placa del vehículo: {Placa}");
            if (TieneRestriccion())
            {
                Console.WriteLine("El vehículo tiene restricción de pico y placa hoy.");
            }
            else
            {
                Console.WriteLine("El vehículo NO tiene restricción de pico y placa hoy.");
            }
        }
    }
}