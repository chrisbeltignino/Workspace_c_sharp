using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            char salida;
            char operador;
            float resultado;
            int x;
            int y;

            do
            {

                Console.WriteLine("Ingrese primer numero: ");
                ingreso = Console.ReadLine();

                while (int.TryParse(ingreso, out x) == false || int.Parse(ingreso) < 0)
                {
                    Console.WriteLine("ERROR, Ingrese un numero valido: ");

                    ingreso = Console.ReadLine();
                }

                Console.WriteLine("Ingrese segundo segundo: ");
                ingreso = Console.ReadLine();

                while (int.TryParse(ingreso, out y) == false || int.Parse(ingreso) < 0)
                {
                    Console.WriteLine("ERROR, Ingrese un numero valido: ");

                    ingreso = Console.ReadLine();
                }


                Console.Write("Ingrese la operacion que desea hacer (+,-,*,/):");
                operador = char.Parse(Console.ReadLine());
                while (operador != '+' && operador != '-' && operador != '*' && operador != '/')
                {
                    Console.WriteLine("ERROR, Ingrese un operador valido: ");

                    operador = char.Parse(Console.ReadLine());
                }

                resultado = Calculadora.Calcular(x,y,operador);

                Console.WriteLine("Operacion: {0} {1} {2} = {3}", x, operador, y, resultado) ;
                Console.ReadLine();

                Console.Write("¿Desea continuar? (S/N)");
                salida = char.Parse(Console.ReadLine());

            } while (Validador.ValidarRespuesta(salida) == true);

        }
    }
}
