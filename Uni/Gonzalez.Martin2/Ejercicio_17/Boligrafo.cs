using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
   public class Boligrafo
    {
        #region Variables
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region Constructor
            public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }
        #endregion

        #region Metodos
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta >= 0 && tinta <= 100)
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            this.SetTinta(gasto)
        }
        #endregion
    }
}
