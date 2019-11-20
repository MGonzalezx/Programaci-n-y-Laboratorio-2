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
                int retorno = 0;
                if(cantidadDePaginas == 0)
                {
                    int numero = Libro.generadorDePaginas.Next(10,570);
                    retorno = numero;
                }
                return retorno;
            }

        }

        static Libro()
        {
            Libro.generadorDePaginas = new Random();

        }
        public Libro(float precio, string titulo, Autor autor) :this(titulo,autor.MiApellido,autor.MiNombre,precio)
        {
            
        }
        public Libro(string titulo, string apellido, string nombre, float precio) 
        {
            
            this.titulo = titulo;
            this.precio = precio;
            this.autor.MiApellido = apellido;
            this.autor.MiNombre = nombre;
            
        }

        private static string Mostrar(Libro l)
        {
            return "Autor: " + l.autor.MiNombre + ", " + l.autor.MiApellido + " - Titulo: " + l.titulo +
                " - Precio: " + l.precio.ToString() + " - Cantidad de Paginas: " + l.cantidadDePaginas;
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
