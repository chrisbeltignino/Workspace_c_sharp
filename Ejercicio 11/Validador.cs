using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            Boolean esValido = false;

            if (respuesta == 's')
            {
                esValido = true;
            }

            return esValido;
        }

        public static bool Validar(int valor, int min, int max)
        {
            Boolean esValido = false;

            if ((valor >= min) && (valor <= max))
            {
                esValido = true;
            }

            return esValido;
        }
    }
}
