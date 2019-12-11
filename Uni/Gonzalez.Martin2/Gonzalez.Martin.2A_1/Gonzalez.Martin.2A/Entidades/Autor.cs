using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        //public string MiNombre { get { return this.nombre; } set { this.nombre = value ; } }
        //public string MiApellido { get { return this.apellido; } set { this.apellido = value; } }

        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static implicit operator string(Autor a)
        {
            return "Nombre: " + a.nombre + " - Apellido: " + a.apellido;
        }

        public static bool operator ==(Autor a, Autor b)
        {
            bool retorno = false;
            if (a.nombre == b.nombre && a.apellido == b.apellido)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
    }
}
