using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro 
    {
        protected Autor autor;
        protected int cantidadDePaginas;
        protected static Random generadorDePaginas;
        protected float precio;
        protected string titulo;

        public int CantidadDePaginas
        {
            get
            {
              
                if(this.cantidadDePaginas == 0)
                {
                    this.cantidadDePaginas = Libro.generadorDePaginas.Next(10,571);
                }
                return this.cantidadDePaginas;
            }

        }

        static Libro()
        {
            Libro.generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, Autor autor) 
        {
            this.titulo = titulo;
            this.precio = precio;
            this.autor = autor;
        }
        public Libro(string titulo, string apellido, string nombre, float precio) : this(precio,titulo, new Autor(nombre,apellido))
        {
           
            
        }

        private static string Mostrar(Libro l)
        {
            return "Autor: " + l.autor + " - Titulo: " + l.titulo +
                " - Precio: " + l.precio.ToString() + " - Cantidad de Paginas: " + l.CantidadDePaginas;
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }

        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;
            if (a.autor == b.autor && a.titulo == b.titulo)
            {
                return retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        { 
            return !(a == b);
        }
    }
}
