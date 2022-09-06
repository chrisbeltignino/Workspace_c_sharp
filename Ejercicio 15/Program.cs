using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un cuadrado de lado 5: " + CalculadoraDeArea.CalcularAreaCuadrado(5));

            Console.WriteLine("Area de un triangulo de base 2 y altura 3: " + CalculadoraDeArea.CalcularAreaTriangulo(2, 3));

            Console.WriteLine("Area de un circulo de radio 3: " + CalculadoraDeArea.CalcularAreaCirculo(3));
        }
    }
}
