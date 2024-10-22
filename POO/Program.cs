using POO;

namespace POO
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("ABC123");
            vehiculo.Run();

            Rectangulo rectangulo= new Rectangulo(5.0, 4.0);
            rectangulo.Run();

            Circulo circulo = new Circulo(3.0);
            circulo.Run();

            Power power = new Power();
            power.Run(2.0, 3);

            Ave.Canario canario = new Ave.Canario("Amarillo");
            Ave.Aguila aguila = new Ave.Aguila("Marrón y Blanco");
            Ave.Pinguino pinguino = new Ave.Pinguino("Blanco y Negro");

            canario.Cantar();
            aguila.Volar();
            pinguino.Volar();
        }
    }
}
