using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingresar un numero: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                double elevadoAlCubo = Math.Pow(numero, 3); // Elevarlo a la potencia 3
                double elevadoAlCuadrado = Math.Pow(numero, 2); // Elevarlo a la potencia 2

                Console.WriteLine("{0} elevado al cubo es {1} \n{0} elevado al cuadrado es {2}", numero, elevadoAlCubo, elevadoAlCuadrado);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.ReadLine();
            }
        }
    }
}
