using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Calculadora
    {
        public static float Calcular(int x, int y, char operador)
        {
            float resultado = 0;

            switch(operador)
            {
                case '+':
                    resultado = x + y;
                break;
                case '-':
                    resultado = x - y;
                break;
                case '*':
                    resultado = x * y;
                break;
                case '/':
                    if (Validar(y) == true)
                    {
                        resultado = x / y;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir por 0");
                    }
               break;
            }

            return resultado;
        }

        private static bool Validar(int y)
        {
            bool isOk = false;

            if(y != 0)
            {
                isOk = true;
            }

            return isOk;
        }
    }
}
