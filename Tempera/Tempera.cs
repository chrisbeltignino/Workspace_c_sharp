using System;

namespace Tempera
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private Int32 cantidad;

        //construct

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        //Mostrar y sobrecarga string
        private string Mostrar()
        {
            return (string)this;
        }

        public string Mostrar(Tempera tempera)
        {
            return Mostrar();
        }

        public static explicit operator string(Tempera tempera)
        {
            return $"Color {tempera.color} Marca {tempera.marca} Cantidad {(int)tempera}";
        }

        //sobrecarga operadores (+; ==; !=; -)

        public static bool operator ==(Tempera temperaX, Tempera temperaY)
        {
            bool equals = false;
            if ((temperaX.color == temperaY.color) && (temperaX.marca == temperaY.marca))
            {
                equals = true;
            }

            return equals;
        }
        public static bool operator !=(Tempera temperaX, Tempera temperaY)
        {
            bool nonEquals = false;
            if (!((temperaX.color == temperaY.color) && (temperaX.marca == temperaY.marca)))
            {
                nonEquals = true;
            }

            return nonEquals;
        }

        public static implicit operator int(Tempera tempera)
        {
            return tempera.cantidad;
        }

        public static Tempera operator +(Tempera temperaX, Tempera temperaY)
        {
            if (temperaX == temperaY)
            {
                temperaX.cantidad = +(int)temperaY;
            }

            return temperaX;
        }

        public static Tempera operator +(Tempera tempera, int x)
        {
            tempera.cantidad = +x;
            return tempera;
        }
    }
}
