using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class TeoremaDePitagoras
    {
        public static float CalcularLongitud(float x, float y)
        {
            float operacion;
            float resultado;

            operacion = x * x + y * y;

            operacion = MathF.Pow(x, 20) + MathF.Pow(y, 2);

            resultado = MathF.Sqrt(operacion);

            return resultado;
        }
    }
}
