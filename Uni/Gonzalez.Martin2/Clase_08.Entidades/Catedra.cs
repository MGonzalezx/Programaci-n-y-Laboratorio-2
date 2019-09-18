using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_08.Entidades
{
    public class Catedra
    {
        #region Variables
        private List<Alumno> alumnos;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos { get { return this.alumnos; } }
        #endregion

        #region Constructores
        public Catedra()
        {
            alumnos = new List<Alumno>();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Catedra c, Alumno a)
        {
            bool retorno = false;
            //if (Catedra.Equals(c, null) && Alumno.Equals(a, null))
            //{
            //    return retorno = true;
            //}
            //else if ((Catedra.Equals(c, null) && Alumno.Equals(a, null) == false) ||
            //        (Catedra.Equals(c, null) == false && Alumno.Equals(a, null)))
            //{
            //    return retorno;
            //}
            foreach (Alumno auxAlumno in c.alumnos)
            {
                if (auxAlumno == a)
                {
                    return retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;
            if (c == a)
            {
                return retorno;
            }
            else
            {
                c.alumnos.Add(a);
                return retorno = true;
            }
        }

        public static int operator |(Alumno a, Catedra c)
        {
            for (int i = 0; i < c.alumnos.Count; i++)
            {
                if (c.alumnos[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool operator -(Catedra c, Alumno a)
        {
            bool retorno = false;
            if (c == a)
            {
                c.alumnos.Remove(a);
                return retorno = true;
            }
            else
            {
                return retorno ;
            }
        }
        #endregion
    }
}
