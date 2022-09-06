using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int resultado;
            int numero;

            Console.Write("Ingrese primer numero: ");
            ingreso = Console.ReadLine();

            while (int.TryParse(ingreso, out numero) == false || int.Parse(ingreso) < 0)
            {
                Console.Write("ERROR, Ingrese un numero valido: ");

                ingreso = Console.ReadLine();
            }

            Tabla(numero);
        }

        static void Tabla(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", numero, i, (numero * i));
            }
        }
    }
}
