using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_08.Entidades
{
    public class Alumno
    {
        #region Variables
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;
        #endregion

        #region Propiedades
        public string Apellido { get { return this.apellido; } }

        public ETipoExamen Examen { get { return this.examen; } }

        public int Legajo { get { return this.legajo; } }

        public string Nombre { get { return this.nombre; } }
        #endregion

        #region Metodos
        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        public static string Mostrar(Alumno a)
        {
            return "Nombre: " + a.nombre + " - Apellido: " + a.apellido + " - Legajo: " + a.legajo.ToString() +
                " - Tipo De Examen: " + a.examen.ToString(); 
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            int retorno;
            retorno = a.apellido.CompareTo(b);
            return retorno;
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return Alumno.OrdenarPorApellidoAsc(b, a);
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            int retorno;
            retorno = a.legajo.CompareTo(b);
            return retorno;
        }

        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            return Alumno.OrdenarPorLegajoAsc(b, a);
        }
        #endregion

        #region Operadores
        public static bool operator ==(Alumno a, Alumno b)
        {
            //if (Alumno.Equals(a, null) && Alumno.Equals(b, null))
            //{
            //    return true;
            //}
            //else if ((Alumno.Equals(a, null) && Alumno.Equals(b, null) == false) ||
            //    (Alumno.Equals(a, null) == false && Alumno.Equals(b, null)))
            //{
            //    return false;
            //}
            return (a.legajo == b.legajo);
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }
        #endregion
    }
}
