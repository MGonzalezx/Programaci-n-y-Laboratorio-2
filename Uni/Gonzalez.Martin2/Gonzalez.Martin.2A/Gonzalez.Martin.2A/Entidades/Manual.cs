using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        public ETipo tipo;

        public Manual(string titulo, string apellido, string nombre, float precio, ETipo tipo) : base(titulo,apellido,nombre,precio)
        {
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return "Autor: " + this.autor.MiNombre + ", " + this.autor.MiApellido + " - Titulo: " + this.titulo +
                 " - Precio: " + this.precio.ToString() + " - Tipo: " + this.tipo;
        }

        public override bool Equals(object obj)
        {

            if (obj is Manual)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }

        public static bool operator ==(Manual a, Manual b)
        {
            bool retorno = false;
            if (a.titulo == b.titulo && a.tipo == b.tipo)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
    }
}
