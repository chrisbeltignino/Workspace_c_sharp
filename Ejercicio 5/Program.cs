using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int sumaAdelante;
            int sumaAtras;
            int n = 1;

            Console.WriteLine("Ingrese su numero:");

            numeroIngresado = int.Parse(Console.ReadLine());

            for (int i = 2; i < numeroIngresado; i++)
            {
                sumaAdelante = 0;
                sumaAtras = 0;

                for (int d = 1; d < i; d++)
                {
                    sumaAtras = sumaAtras + d;
                }

                for (int b = i + 1; b <= sumaAtras; b++)
                {
                    sumaAdelante = sumaAdelante + b;

                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    {
                        break;
                    }

                }

                if (sumaAdelante == sumaAtras)
                {
                    Console.WriteLine("*-----------------------------*", n, i);
                    Console.WriteLine("CENTRO NUMERICO N°{0}: {1}", n, i);
                    Console.WriteLine("*-----------------------------*", n, i);
                    n++;
                }
            }
        }
    }
}
