using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Entidades
{
    public class Libro
    {
        #region Variables
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;
        #endregion

        #region Propiedades
        public string Titulo { get { return this.titulo; } }
        public string Autor { get { return this.autor; } }
        public int CantidadDePaginas { get{ } }
        public int CantidadDeCapitulos { get { } }
        #endregion

        #region Constructores
        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            capitulos = new List<Capitulo>();
        }
        #endregion

        #region Metodos
        //get Si indice excede (menor que 0, supera a cantidadmaxima)rango, retorna null
        //get capitulo en dicho indice
        //set si indice supera rango, (supera a cantidad maxima +1) se agrega, sino se reemplaza
        //capitulo en dicho indice
        public Capitulo this[int index]
        {
            get { if (index < 0 || index > this.capitulos[index]
                {

                }
                }
            set { /* set the specified index to value here */ }
        }
        #endregion

    }

}
