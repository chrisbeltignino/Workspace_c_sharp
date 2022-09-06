using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1A
{
    class Valilador
    {
        public static bool Validar(int valor, int min, int max)
        {
            Boolean esValido = false;

            if((valor >= min) && (valor <= max))
            {
                Console.WriteLine("entre");
                esValido = true;
            }

            return esValido;
        }
    }
}
