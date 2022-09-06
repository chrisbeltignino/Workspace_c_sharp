using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
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
    }
}
