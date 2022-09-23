using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaClass
{
    public class Paleta
    {
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        public Paleta()
        {
            temperas = new List<Tempera>();
        }

        public Paleta(int cantidadMax) : this()
        {
            this.cantidadMaximaColores = cantidadMax;
        }

        public static implicit operator int(Paleta paleta)
        {
            return paleta.cantidadMaximaColores;
        }

        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Tiene un total de {this.cantidadMaximaColores} colores");

            foreach (Tempera tempera in temperas)
            {
                retorno.AppendLine(Tempera.Mostrar(tempera));
            }

            return retorno.ToString();
        }

        private int obtenerIndice(Tempera buscarTempera)
        {
            int retorno = -1;
            int contador = 0;

            foreach (Tempera tempera in temperas)
            {
                contador += 1;

                if (buscarTempera == tempera)
                {
                    retorno = contador;
                    break;
                }
            }

            return retorno;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            return paleta.obtenerIndice(tempera) > 0;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.obtenerIndice(tempera);

            if (indice > 0)
            {
                paleta.temperas[indice - 1] += tempera;
            }
            else
            {
                if (paleta.cantidadMaximaColores > paleta.temperas.Count)
                {
                    paleta.temperas.Add(tempera);
                }
            }

            return paleta;
        }

        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.obtenerIndice(tempera);

            if (indice > 0)
            {
                paleta.temperas[indice - 1] += (-tempera);

                if (paleta.temperas[indice - 1] <= 0)
                {
                    paleta.temperas.RemoveAt(indice - 1);
                }
            }

            return paleta;
        }

        public static Paleta operator +(Paleta paleta1, Paleta paleta2)
        {
            Paleta paletaRetorno = new Paleta(paleta1.cantidadMaximaColores + paleta2.cantidadMaximaColores);

            for (int i = 0; i < paleta1.temperas.Count; i++)
            {
                paletaRetorno.temperas.Add(paleta1.temperas[i]);
            }

            for (int i = 0; i < paleta2.temperas.Count; i++)
            {
                if (paletaRetorno.temperas.Contains(paleta2.temperas[i]))
                {
                    paletaRetorno += paleta2.temperas[i];
                }
                else
                {
                    paletaRetorno.temperas.Add(paleta2.temperas[i]);
                }
            }

            return paletaRetorno;
        }
    }
}
