using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio_6
    {
        public void Run()
        {
            int opcion;
            do
            {
                Console.WriteLine("Seleccione la figura geométrica para calcular el área:");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Paralelogramo");
                Console.WriteLine("4. Rombo");
                Console.WriteLine("5. Trapecio");
                Console.WriteLine("6. Triángulo");
                Console.WriteLine("7. Triángulo Equilátero");
                Console.WriteLine("8. Triángulo Rectángulo");
                Console.WriteLine("9. Polígono Regular");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Rectángulo
                        Console.Write("Ingrese la base (a): ");
                        double baseRect = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura (b): ");
                        double alturaRect = double.Parse(Console.ReadLine());
                        double areaRect = baseRect * alturaRect;
                        Console.WriteLine($"El área del rectángulo es: {areaRect}");
                        break;

                    case 2: // Cuadrado
                        Console.Write("Ingrese el lado (a): ");
                        double ladoCuadrado = double.Parse(Console.ReadLine());
                        double areaCuadrado = ladoCuadrado * ladoCuadrado;
                        Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
                        break;

                    case 3: // Paralelogramo
                        Console.Write("Ingrese la base (b): ");
                        double baseParal = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura (h): ");
                        double alturaParal = double.Parse(Console.ReadLine());
                        double areaParal = baseParal * alturaParal;
                        Console.WriteLine($"El área del paralelogramo es: {areaParal}");
                        break;

                    case 4: // Rombo
                        Console.Write("Ingrese la diagonal mayor (D): ");
                        double diagMayor = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la diagonal menor (d): ");
                        double diagMenor = double.Parse(Console.ReadLine());
                        double areaRombo = (diagMayor * diagMenor) / 2;
                        Console.WriteLine($"El área del rombo es: {areaRombo}");
                        break;

                    case 5: // Trapecio
                        Console.Write("Ingrese la base mayor (a): ");
                        double baseMayor = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la base menor (b): ");
                        double baseMenor = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura (h): ");
                        double alturaTrap = double.Parse(Console.ReadLine());
                        double areaTrap = ((baseMayor + baseMenor) / 2) * alturaTrap;
                        Console.WriteLine($"El área del trapecio es: {areaTrap}");
                        break;

                    case 6: // Triángulo
                        Console.Write("Ingrese la base (a): ");
                        double baseTri = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura (h): ");
                        double alturaTri = double.Parse(Console.ReadLine());
                        double areaTri = (baseTri * alturaTri) / 2;
                        Console.WriteLine($"El área del triángulo es: {areaTri}");
                        break;

                    case 7: // Triángulo Equilátero
                        Console.Write("Ingrese el lado (a): ");
                        double ladoEquil = double.Parse(Console.ReadLine());
                        double areaEquil = (Math.Pow(ladoEquil, 2) * Math.Sqrt(3)) / 4;
                        Console.WriteLine($"El área del triángulo equilátero es: {areaEquil}");
                        break;

                    case 8: // Triángulo Rectángulo
                        Console.Write("Ingrese el cateto (a): ");
                        double cateto1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el cateto (b): ");
                        double cateto2 = double.Parse(Console.ReadLine());
                        double areaTriRect = (cateto1 * cateto2) / 2;
                        Console.WriteLine($"El área del triángulo rectángulo es: {areaTriRect}");
                        break;

                    case 9: // Polígono Regular
                        Console.Write("Ingrese el perímetro (P): ");
                        double perimetro = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el apotema (a): ");
                        double apotema = double.Parse(Console.ReadLine());
                        double areaPoligono = (perimetro * apotema) / 2;
                        Console.WriteLine($"El área del polígono regular es: {areaPoligono}");
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
