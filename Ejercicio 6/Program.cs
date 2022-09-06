using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFinal;
            int flagAnio = 1;
            string respuesta;
            Boolean esBis = false;

            do
            {
                Console.WriteLine("Ingrese un año de inicio, o 'SALIR' para terminar el programa:");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out anioInicio) == false && respuesta != "SALIR")
                {
                    Console.WriteLine("ERROR, Ingrese un año de inicio, o 'SALIR' para terminar el programa:");

                    respuesta = Console.ReadLine();
                }

                Console.WriteLine("Ingrese un año de fin, o 'SALIR' para terminar el programa:");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out anioFinal) == false && respuesta != "SALIR")
                {
                    Console.WriteLine("ERROR, Ingrese un año de fin, o 'SALIR' para terminar el programa:");

                    respuesta = Console.ReadLine();
                }

                if (respuesta != "SALIR")
                {
                    for (int i = anioInicio; i < anioFinal; i++)
                    {
                        esBis = false;

                        if ((i % 4) == 0)
                        {
                            esBis = true;
                        }

                        if (((i % 100) == 0) && ((i % 400) == 0))
                        {
                            esBis = true;
                        }

                        if (esBis)
                        {
                            if (flagAnio == 1)
                            {
                                flagAnio = 0;
                                Console.WriteLine("AÑOS BISIESTOS:");
                            }
                            Console.WriteLine("{0}", i);
                        }
                    }

                    if (flagAnio == 1)
                    {
                        Console.WriteLine("NO HAY AÑOS BISIESTOS ENTRE ESE RANGO.");
                    }

                    Console.WriteLine("Desea volver a iterar señor usuario? 'si' para seguir");

                    respuesta = Console.ReadLine();
                }

            } while (respuesta == "si");
        }
    }
}
