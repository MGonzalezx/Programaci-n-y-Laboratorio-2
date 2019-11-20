using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int capacidad;
        private List<Libro> libros;

        public double PrecioDeManuales { get { return this.ObtenerPrecio(ELibro.PrecioDeManuales); } }
        public double PrecioDeNovelas { get { return this.ObtenerPrecio(ELibro.PrecioDeNovelas); } }
        public double PrecioTotal { get { return this.ObtenerPrecio(ELibro.PrecioTotal); } }

        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }
        private Biblioteca(int capacidad)
        {
            this.capacidad = capacidad;
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double gananciaManual = 0;
            double gananciaNovela = 0;
            double ganancia = 0;
            foreach (Libro auxLibro in libros)
            {
                if (auxLibro is Manual)
                {
                    gananciaManual += PrecioDeManuales;

                }
                else if (auxLibro is Novela)
                {
                    gananciaNovela += PrecioDeNovelas;
                }
                
            }
            if (tipoLibro == ELibro.PrecioDeManuales)
            {
                ganancia += gananciaManual;
            }
            else if (tipoLibro == ELibro.PrecioDeNovelas)
            {
                ganancia += gananciaNovela;
            }
            else if (tipoLibro == ELibro.PrecioTotal)
            {
                ganancia = gananciaManual + gananciaNovela;
            }
            return ganancia;
        }

        public static string Mostrar(Biblioteca b)
        {
            string libro = " ";
            string biblioteca = " ";
            string ganancia = " ";
            ganancia = "Total por manuales: " + b.PrecioDeManuales.ToString()
                    + " Total por novelas: " + b.PrecioDeNovelas + " Total: " + b.PrecioTotal;
            biblioteca = "********************************\n" + "Listado de Libros" +
                "************************************\n";
            foreach (Libro auxlibro in b.libros)
            {

                libro += auxlibro.ToString() + "\n\n";

            }
            return ganancia + biblioteca + libro;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca biblioteca = new Biblioteca(capacidad);
            return biblioteca;
        }

        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool retorno = false;
            foreach (Libro auxLibro in b.libros)
            {
                if (auxLibro == l)
                {
                    return retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            bool retorno = false;
            if (b.libros.Count < b.capacidad && b != l)
            {
                b.libros.Add(l);
               retorno = true;
            }
            else
            {
                Console.WriteLine("No se pudo agregar un nuevo libro");
            }
            return b;
        }
    }
}
