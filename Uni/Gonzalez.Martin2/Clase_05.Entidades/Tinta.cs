using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    
    public class Tinta
    {
        //VARIABLES
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        #region Constructores
        
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.comun;
        }
        
        public Tinta(ETipoTinta tinta) : this()
        {
            this._tipo = tinta;

        }
        public Tinta(ETipoTinta tinta, ConsoleColor color) : this(tinta)
        {
            this._color = color;
        }
        #endregion

        #region Metodos
        
        private string Mostrar()
        {
            return "Tinta: " + this._tipo.ToString() + " - Color: " + this._color.ToString() + "\n";
        }

        
        public static string Mostrar(Tinta ver)
        {
            return ver.Mostrar();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {

            if (!object.Equals(tinta1, null) && !object.Equals(tinta2, null))
            {
                //logica de negocio
                return tinta1._tipo == tinta2._tipo;
            }
            else
            {

                return Object.Equals(tinta1, tinta2);

            }
            
        }
        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            bool retorno = false;
            if (tinta._color == color)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta == color);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        #endregion
    }
}
