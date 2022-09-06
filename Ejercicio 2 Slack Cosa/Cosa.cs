using System;
using System.Text;

namespace Ejercicio_2_Slack_Cosa
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = 0;
            this.cadena = "";
            this.fecha = new DateTime();
        }
        public void EstablecerValor(int numero)
        {
            this.entero = numero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El entero es {this.entero}");
            sb.AppendLine($"La cadena es {this.cadena}");
            sb.AppendLine($"La fecha es {this.fecha.ToShortDateString()}");

            return sb.ToString();
        }

        public static string Mostrar(Cosa cosa)
        {
            return cosa.Mostrar();
        }
    }
}
