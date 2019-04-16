using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.entidades
{
    public class Paleta
    {
    // private Tempera[] _temperas;
    List<Tempera> tempera;
    private int _cantidadMaxima;
    private Paleta() : this(5)
        {
        }
        private Paleta(int cantidad)
        {
      this._cantidadMaxima = cantidad;
      //this._temperas = new Tempera[cantidad];
         this.tempera = new List<Tempera>(cantidad);
    }
        public static implicit operator Paleta(int cantidad)
        {
            Paleta paleta = new Paleta(cantidad);
            return paleta;
        }
        private string Mostrar()
        {
            string retorno = "Cantidad maxima: " + this._cantidadMaxima.ToString() + "  Temperas: ";
            {
                foreach (Tempera tempera in this.tempera) //this._temperas)
                {
                    if (tempera != null)
                    {
                        retorno += Tempera.Mostrar(tempera) + "\n";
                    }
                }
            }
            return retorno;
        }

        public static explicit operator string (Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator == (Paleta MiPaleta, Tempera MiTempera)
        {
            bool retorno = false;
            if(Paleta.Equals(MiPaleta, null) || MiTempera == null)
            {
                retorno = false;
            }
            foreach(Tempera auxTempera in MiPaleta.tempera) //_temperas)
            {
                if(auxTempera == MiTempera)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        private int ObtenerIndice()
        {
            for (int i = 0; i < tempera.Count; i++) //_temperas.Length; i++)
            {
                if(this.tempera[i] == null)//_temperas[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool operator !=(Paleta MiPaleta, Tempera MiTempera)
        {
            return !(MiPaleta == MiTempera);
        }

        public static Paleta operator + (Paleta MiPaleta, Tempera MiTempera)
        {
            int indice = MiPaleta.ObtenerIndice();
            if(MiPaleta != MiTempera && indice != -1)
            {
              MiPaleta.tempera[indice] = MiTempera;//_temperas[indice] = MiTempera;
            }
            return MiPaleta;
        }


    }
}
