using System;

namespace Ejercicio_2_Slack
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa.Cosa cosa = new Cosa.Cosa();

            cosa.EstablecerValor(2);
            cosa.EstablecerValor("cosa");
            cosa.EstablecerValor(DateTime.Now);

            Console.WriteLine(Cosa.Cosa.Mostrar(cosa));
        }
    }
}
