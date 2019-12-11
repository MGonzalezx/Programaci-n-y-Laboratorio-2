using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero) : base(precio,titulo,autor)
        {
            this.genero = genero;
        }

        public override string ToString()
        {
            return (string)this + " Genero: " + this.genero;
            //return "Autor: " + this.autor + " - Titulo: " + this.titulo +
            //     " - Precio: " + this.precio.ToString() + " - Genero: " + this.genero;
        }

        public override bool Equals(object obj)
        {

            if (obj is Novela)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static implicit operator Single(Novela n)
        {
            return n.precio;
        }

        public static bool operator ==(Novela a, Novela b)
        {
            bool retorno = false;
            if (a.titulo == b.titulo && a.genero == b.genero)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
    }
}
