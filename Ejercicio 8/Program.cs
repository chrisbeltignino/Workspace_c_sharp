using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int alturaIngresada;
            int asteriscos = 0;

            Console.WriteLine("Ingrese la altura del triángulo: ");

            respuesta = Console.ReadLine();

            while (int.TryParse(respuesta, out alturaIngresada) == false || int.Parse(respuesta) <= 0)
            {
                Console.WriteLine("ERROR, Ingrese una altura válida: ");

                respuesta = Console.ReadLine();
            }

            for (int i = 1; i <= alturaIngresada; i++)
            {
                asteriscos = (i * 2) - 1;

                for (int a = 0; a < asteriscos; a++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
