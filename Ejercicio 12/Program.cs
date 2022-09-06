using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numeroIngresado;
            int binario;
            int decimall;

            Console.Write("Ingrese un numero: ");
            respuesta = Console.ReadLine();

            while (int.TryParse(respuesta, out numeroIngresado)==false)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                respuesta = Console.ReadLine();
            }

            binario = Conversor.ConvertirDecimalABinario(numeroIngresado);
            decimall = Conversor.ConvertirBinarioADecimal(binario);

            Console.WriteLine("Numero decimal ingresado: {0}, Numero binario: {1}, Numero de binario a decimal: {2}", numeroIngresado, binario, decimall);
            Console.ReadLine();
        }
    }
}
