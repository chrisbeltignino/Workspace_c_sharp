using System;
using System.Text;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaIngresada = new DateTime();
            Console.Write("Ingrese su fecha de nacimiento(DD/MM/AAAA): ");
            fechaIngresada = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(CalcularAños.Edad(fechaIngresada));
        }
    }
}
