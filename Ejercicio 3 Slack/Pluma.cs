using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Slack
{
    class Pluma
    {
        private string marca;
        private Tinta Tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.Tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca, Tinta tinta):this()
        {
            this.marca = "Sin marca";
            this.Tinta = null;
        }
    }
}
