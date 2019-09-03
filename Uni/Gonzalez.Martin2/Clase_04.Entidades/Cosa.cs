using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public string Monstrar()
        {
            return "Valor entero: " + this.entero.ToString() + " - Cadena: " + this.cadena +
                " - Fecha: " + this.fecha.ToString() + "\n";
        }

        public Cosa()
        {
            this.entero = -1;
            this.cadena = " ";
            this.fecha = DateTime.Now;
        }

        public Cosa(string str) :this()
        {
            //this.entero = -1;
            this.cadena = str;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string str, DateTime fecha) :this(str)
        {
            //this.entero = -1;
            //this.cadena = str;
            this.fecha = fecha;
        }

        public Cosa(string str, DateTime fecha, int entero) : this(str, fecha)
        {
            //this.fecha = fecha;
            //this.cadena = str;
            this.entero = entero;
        }
    }
}
