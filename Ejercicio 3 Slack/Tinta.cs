using System;
using System.Text;

namespace Ejercicio_3_Slack
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Black;
            tipo = ETipoTinta.Comun;
        }
        public Tinta(ETipoTinta tipo):this()
        {
            this.tipo = tipo;
        }

        public Tinta(ETipoTinta tipo, ConsoleColor color):this(tipo)
        {
            this.color = color;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"color: {this.color}");
            sb.AppendLine($"tipo: {this.tipo}");

            return sb.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator == (Tinta t1, Tinta t2)
        {
            bool isOk = false;

            if(t1.color == t2.color && t1.tipo == t2.tipo)
            {
                isOk = true;
            }

            return isOk;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }
}
