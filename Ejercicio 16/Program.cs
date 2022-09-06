using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            float resultado;
            float x;
            float y;

            Console.WriteLine("Ingrese cateto 1: ");
            ingreso = Console.ReadLine();

            while (float.TryParse(ingreso, out x) == false || float.Parse(ingreso) < 0)
            {
                Console.WriteLine("ERROR, Ingrese un numero valido: ");

                ingreso = Console.ReadLine();
            }

            Console.WriteLine("Ingrese cateto 2: ");
            ingreso = Console.ReadLine();

            while (float.TryParse(ingreso, out y) == false || float.Parse(ingreso) < 0)
            {
                Console.WriteLine("ERROR, Ingrese un numero valido: ");

                ingreso = Console.ReadLine();
            }

            resultado = TeoremaDePitagoras.CalcularLongitud(x, y);

            Console.WriteLine("La hipotenusa es: {0}", resultado);
        }
    }
}
