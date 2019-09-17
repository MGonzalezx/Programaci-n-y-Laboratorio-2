using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Entidades
{
    public class Capitulo
    {
        #region Variables
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;
        #endregion

        #region Propiedades
        public int Numero { get{ return this.numero; } }
        public string Titulo { get { return this.titulo; } }
        public int Paginas { get { return this.paginas; } }
        #endregion

        #region Constructores
        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
             
        }
        private Capitulo(int numero, string titulo, int paginas)
        {
            this.numero = numero;
            this.titulo = titulo;
            this.paginas = paginas;
        }
        #endregion

        #region Operadores
        public static implicit operator Capitulo(string titulo)
        {
            //Capitulo.generadorDeNumeros.Next(1, 65);
            //Capitulo.generadorDePaginas.Next(15, 233);
            int numero = Capitulo.generadorDeNumeros.Next(1, 65);
            int pagina = Capitulo.generadorDePaginas.Next(15, 233);
            Capitulo capitulo = new Capitulo(numero, titulo, pagina);
            return capitulo;
            
        }

        //COMPARANDO TITULOS Y NUMEROS
        public static bool operator ==(Capitulo tituloNumero, Capitulo titulo)
        {
            if (Capitulo.Equals(tituloNumero, null) && Capitulo.Equals(titulo, null))
            {
                return true;
            }
            else if ((Capitulo.Equals(tituloNumero, null) && Capitulo.Equals(titulo, null) == false) ||
                (Capitulo.Equals(tituloNumero, null) == false && Capitulo.Equals(titulo, null)))
            {
                return false;
            }
            return (tituloNumero.numero == titulo.numero && tituloNumero.titulo.Equals(titulo.titulo));
        }
        public static bool operator !=(Capitulo numero, Capitulo titulo)
        {
            return !(numero == titulo);
        }
        #endregion
    }
}
