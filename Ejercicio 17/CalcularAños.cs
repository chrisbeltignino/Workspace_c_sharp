using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class CalcularAños
    {
        public static string Edad(DateTime FechaNac)
        {
            int Años = 0;
            int Meses = 0;
            int Dias = 0;
            string txtdias;
            DateTime FechaCalculo;

            FechaCalculo = FechaNac;

            if (FechaNac > DateTime.Today)
            {

                return "Error. Fecha futura";
            }

            while (FechaCalculo.AddYears(1) <= DateTime.Today) // comprobamos los años que ha cumplido
            {
                Años = Años + 1;
                FechaCalculo = FechaCalculo.AddYears(1); // añadiendo años a la fecha de nacimiento
            }

            while (FechaCalculo.AddMonths(1) <= DateTime.Today) // comprobamos los meses que ha cumplido
            {
                Meses = Meses + 1;
                FechaCalculo = FechaCalculo.AddMonths(1); // añadiendo meses
            }

            while (FechaCalculo.AddDays(1) <= DateTime.Today) // finalmente comprobamos los dias que ha cumplido
            {
                Dias = Dias + 1;
                FechaCalculo = FechaCalculo.AddDays(1);
            }

            txtdias = (Dias + 1).ToString();

            return txtdias;
        }
    }
}
