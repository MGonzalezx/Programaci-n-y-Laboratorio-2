using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        #region Variables
        private Tempera[] colores;
        private int cantidadMaximaColores;
        #endregion

        #region Constructor
        private Paleta() : this (5)
        {
            
        }
        private Paleta(int cantidadMaximaColores)
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
            this.colores = new Tempera[cantidadMaximaColores];

        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string retorno = "Cantidad maxima: " + this.cantidadMaximaColores.ToString() + "  Temperas: ";
            //this.colores = new Tempera[cantidadMaximaColores];
            {
                foreach (Tempera tempera in this.colores)
                {
                    if (tempera != null)
                    {
                        retorno += tempera + "\n";
                    }
                }
            }
            return retorno;
        }

        private int ObtenerLugarLibre()
        {
            for (int i = 0; i < colores.Length; i++) 
            {
                if (this.colores[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Operadores
        public static implicit operator Paleta(int entero)
        {
            Paleta paleta = new Paleta(entero);

            return paleta;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        //DEVUELVE TRUE SI TEMP ESTA EN PALETA
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;
            if (Paleta.Equals(paleta, null) || Paleta.Equals(tempera, null))
            {
                return retorno;
            }
            foreach (Tempera auxTempera in paleta.colores)
            {
                if (auxTempera == tempera)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        //SI TEMP NO ESTA EN PALETA, SE AGREGA EN PRIMER LUGAR "LIBRE"
        //SI TEMP ESTA EN PALETA, ACUMULO CANTIDADES
        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.ObtenerLugarLibre();
            if(paleta != tempera && indice != -1)
            {
                 paleta.colores[indice] = tempera;
            }
            if (paleta == tempera)
            {
                paleta.colores[indice] += tempera;
            }
              return paleta;
        }

        //RETORNA EL INDICE DE LA TEMPERA SI LA TEMPERA ESTA EN LA PALETA
        public static int operator | (Paleta paleta, Tempera tempera)
        {
            for (int i = 0; i < paleta.colores.Length; i++)
            {
                if (paleta.colores[i] == tempera)
                {
                    return i;
                }
            }
            return -1;
        }

        //SI LA TEMPERA SE ENCUENTRA EN LA PALETA, DECREMENTAR LAS CANTIDADES
        //SI CUANDO LA ESTOY QUITANDO Y LA RESTA ME DA 0 O MENOS QUE 0, ESE LUGAR QUEDA EN NULL
        public static int operator -(Paleta paleta, Tempera tempera)
        {

        }
        #endregion
    }
}
