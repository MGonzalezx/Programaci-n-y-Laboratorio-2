using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Materia
    {
        #region Variables
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos { get { return this._alumnos; } set { } }
        public EMateria Nombre { get { return this._nombre; } set { } }
        #endregion

        #region Constructores
        private Materia()
        {
            this._alumnos = new List<Alumno>();
        }
        private Materia(EMateria nombre) : this()
        {
            this._nombre = nombre;
        }
        static Materia()
        {
            Materia._notaParaUnAlumno = new Random();
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string Alumnos = " ";
            foreach (Alumno auxAlumno in this._alumnos)
            {
                Alumnos += Alumno.Mostrar(auxAlumno);
            }
            return "\nMateria: " + this._nombre + "\n" + "***************************************"
            + "\n***************ALUMNOS*****************" + "\n" + Alumnos;
        }

        public void CalificarAlumnos()
        {
            foreach (Alumno auxAlumno in this._alumnos)
            {
                auxAlumno.Nota = Materia._notaParaUnAlumno.Next(1, 10);
            }
        }
        #endregion

        #region Operadoes
        public static implicit operator Materia(EMateria nombre)
        {
            Materia materia = new Materia(nombre);

            return materia;
        }

        public static implicit operator float(Materia m)
        {
            float promedio = 0;
            foreach (Alumno auxAlumno in m._alumnos)
            {
                promedio += auxAlumno.Nota;
            }
            return promedio / m._alumnos.Count;

        }

        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }


        public static bool operator ==(Materia m, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno auxAlumno in m._alumnos)
            {
                if (auxAlumno == a)
                {
                    return retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static Materia operator +(Materia m, Alumno a)
        {
            if (m != a)
            {
                m._alumnos.Add(a);
                Console.WriteLine("Se agregó el alumno en la materia {0}!!!", m._nombre);
            }
            else
            {
                Console.WriteLine("El Alumno ya esta en la materia {0}!!!", m._nombre);
            }

            return m;
        }

        public static Materia operator -(Materia m, Alumno a)
        {
            if (m == a)
            {
                m._alumnos.Remove(a);
                Console.WriteLine("Se quitò el alumno en la materia {0}!!!", m._nombre);
            }
            else
            {
                Console.WriteLine("El alumno no está en la materia {0}!!!", m._nombre);
            }

            return m;
        }

        #endregion
    }
}
