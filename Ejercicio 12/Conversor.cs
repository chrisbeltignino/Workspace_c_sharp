using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Conversor
    {
        public static int ConvertirDecimalABinario(int numeroEntero)
        {
            int binario = 0;
            int digito = 0;

            for (int i = numeroEntero % 2, j = 0; numeroEntero > 0; numeroEntero /= 2, i = numeroEntero % 2, j++)
            {
                digito = i % 2;
                binario += digito * (int)Math.Pow(10, j);
            }

            return binario;
        }
        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            int numero = 0;
            int digito = 0;

            for (long i = numeroEntero, j = 0; i > 0; i /= 10, j++)
            {
                digito = (int)i % 10;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }

            return numero;
        }
    }
}
