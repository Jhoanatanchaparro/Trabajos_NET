using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_7
    {
        public void Run()
        {
            int opcion;
            do
            {
                Console.WriteLine("Seleccione la conversión de temperatura que desea realizar:");
                Console.WriteLine("1. Fahrenheit a Celsius");
                Console.WriteLine("2. Fahrenheit a Kelvin");
                Console.WriteLine("3. Fahrenheit a Rankine");
                Console.WriteLine("4. Fahrenheit a Réaumur");
                Console.WriteLine("5. Celsius a Fahrenheit");
                Console.WriteLine("6. Celsius a Kelvin");
                Console.WriteLine("7. Celsius a Rankine");
                Console.WriteLine("8. Celsius a Réaumur");
                Console.WriteLine("9. Kelvin a Celsius");
                Console.WriteLine("10. Kelvin a Fahrenheit");
                Console.WriteLine("11. Kelvin a Rankine");
                Console.WriteLine("12. Kelvin a Réaumur");
                Console.WriteLine("13. Rankine a Celsius");
                Console.WriteLine("14. Rankine a Fahrenheit");
                Console.WriteLine("15. Rankine a Kelvin");
                Console.WriteLine("16. Rankine a Réaumur");
                Console.WriteLine("17. Réaumur a Celsius");
                Console.WriteLine("18. Réaumur a Fahrenheit");
                Console.WriteLine("19. Réaumur a Kelvin");
                Console.WriteLine("20. Réaumur a Rankine");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                double resultado = 0;
                double temperatura;

                switch (opcion)
                {
                    case 1: // Fahrenheit a Celsius
                        Console.Write("Ingrese la temperatura en Fahrenheit: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 32) / 1.8;
                        Console.WriteLine($"La temperatura en Celsius es: {resultado}");
                        break;

                    case 2: // Fahrenheit a Kelvin
                        Console.Write("Ingrese la temperatura en Fahrenheit: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura + 459.67) / 1.8;
                        Console.WriteLine($"La temperatura en Kelvin es: {resultado}");
                        break;

                    case 3: // Fahrenheit a Rankine
                        Console.Write("Ingrese la temperatura en Fahrenheit: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura + 459.67;
                        Console.WriteLine($"La temperatura en Rankine es: {resultado}");
                        break;

                    case 4: // Fahrenheit a Réaumur
                        Console.Write("Ingrese la temperatura en Fahrenheit: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 32) / 2.25;
                        Console.WriteLine($"La temperatura en Réaumur es: {resultado}");
                        break;

                    case 5: // Celsius a Fahrenheit
                        Console.Write("Ingrese la temperatura en Celsius: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 1.8) + 32;
                        Console.WriteLine($"La temperatura en Fahrenheit es: {resultado}");
                        break;

                    case 6: // Celsius a Kelvin
                        Console.Write("Ingrese la temperatura en Celsius: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura + 273.15;
                        Console.WriteLine($"La temperatura en Kelvin es: {resultado}");
                        break;

                    case 7: // Celsius a Rankine
                        Console.Write("Ingrese la temperatura en Celsius: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 1.8) + 459.67;
                        Console.WriteLine($"La temperatura en Rankine es: {resultado}");
                        break;

                    case 8: // Celsius a Réaumur
                        Console.Write("Ingrese la temperatura en Celsius: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura * 0.8;
                        Console.WriteLine($"La temperatura en Réaumur es: {resultado}");
                        break;

                    case 9: // Kelvin a Celsius
                        Console.Write("Ingrese la temperatura en Kelvin: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura - 273.15;
                        Console.WriteLine($"La temperatura en Celsius es: {resultado}");
                        break;

                    case 10: // Kelvin a Fahrenheit
                        Console.Write("Ingrese la temperatura en Kelvin: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 1.8) - 459.67;
                        Console.WriteLine($"La temperatura en Fahrenheit es: {resultado}");
                        break;

                    case 11: // Kelvin a Rankine
                        Console.Write("Ingrese la temperatura en Kelvin: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura * 1.8;
                        Console.WriteLine($"La temperatura en Rankine es: {resultado}");
                        break;

                    case 12: // Kelvin a Réaumur
                        Console.Write("Ingrese la temperatura en Kelvin: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 273.15) * 0.8;
                        Console.WriteLine($"La temperatura en Réaumur es: {resultado}");
                        break;

                    case 13: // Rankine a Celsius
                        Console.Write("Ingrese la temperatura en Rankine: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 491.67) / 1.8;
                        Console.WriteLine($"La temperatura en Celsius es: {resultado}");
                        break;

                    case 14: // Rankine a Fahrenheit
                        Console.Write("Ingrese la temperatura en Rankine: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura - 459.67;
                        Console.WriteLine($"La temperatura en Fahrenheit es: {resultado}");
                        break;

                    case 15: // Rankine a Kelvin
                        Console.Write("Ingrese la temperatura en Rankine: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura / 1.8;
                        Console.WriteLine($"La temperatura en Kelvin es: {resultado}");
                        break;

                    case 16: // Rankine a Réaumur
                        Console.Write("Ingrese la temperatura en Rankine: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura - 491.67) / 2.25;
                        Console.WriteLine($"La temperatura en Réaumur es: {resultado}");
                        break;

                    case 17: // Réaumur a Celsius
                        Console.Write("Ingrese la temperatura en Réaumur: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = temperatura * 1.25;
                        Console.WriteLine($"La temperatura en Celsius es: {resultado}");
                        break;

                    case 18: // Réaumur a Fahrenheit
                        Console.Write("Ingrese la temperatura en Réaumur: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 2.25) + 32;
                        Console.WriteLine($"La temperatura en Fahrenheit es: {resultado}");
                        break;

                    case 19: // Réaumur a Kelvin
                        Console.Write("Ingrese la temperatura en Réaumur: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 1.25) + 273.15;
                        Console.WriteLine($"La temperatura en Kelvin es: {resultado}");
                        break;

                    case 20: // Réaumur a Rankine
                        Console.Write("Ingrese la temperatura en Réaumur: ");
                        temperatura = double.Parse(Console.ReadLine());
                        resultado = (temperatura * 2.25) + 459.67;
                        Console.WriteLine($"La temperatura en Rankine es: {resultado}");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine(); // Espacio para mejor visualización
            } while (opcion != 0);
        }
    }
}
