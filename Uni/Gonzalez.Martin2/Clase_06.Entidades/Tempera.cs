using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        #region Variables
        private ConsoleColor color;
        private string marca;
        private int cantidad;
        #endregion

        #region Constructores
        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        #endregion

        #region Metodos
        private string Mostrar()
        {
            return "Color: " + this.color.ToString() + " - Marca: " + this.marca + " - Cantidad: "
                + this.cantidad.ToString() + "\n";
        }

        #endregion

        #region Operadores
        public static implicit operator string (Tempera tempera)
        {
            return tempera.Mostrar();
        }

        //MARCA Y COLOR SEAN IGUALES
        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool retorno = false;
            if(tempera1.marca == tempera2.marca && tempera1.color == tempera2.color)
            {
                return retorno = true;
            }
            return retorno;
            
        }
        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }

        public static Tempera operator +(Tempera tempera, int cantidad)
        {
               tempera.cantidad += cantidad;
               return tempera;
        }

        public static Tempera operator -(Tempera tempera, int cantidad)
        {
            tempera.cantidad -= cantidad;
            return tempera;
        }

        //SI TEMPERA SON IGUALES INCREMENTA CANTIDAD
        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {

                tempera1 += tempera2.cantidad;

            }
            return tempera1;
        }
        //SI TEMPERA SON IGUALES DECREMENTA CANTIDAD
        public static Tempera operator -(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {

                tempera1 -= tempera2.cantidad;
  

            }
            return tempera1;
        }
        #endregion
    }
}
