using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        #region Variables
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                if (i > -1 && i < this.jornada.Count())
                {
                    return this.jornada[i];
                }
                return null;
            }
            set
            {
                if (i > -1 && i < this.jornada.Count())
                {
                    this.jornada[i] = value;
                }
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        #endregion

        #region Constructores

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }

        #endregion

        #region Metodos

        private static string MostrarDatos(Universidad uni)
        {
            string retorno = "JORNADA:\n";
            if (!Object.Equals(uni.jornada, null))
            {
                foreach (Jornada jornada in uni.jornada)
                {
                    retorno += jornada.ToString() + "\n";
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        public static bool Guardar(Universidad uni)
        {
            try
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Universidad.xml", uni);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

        }

        public static Universidad Leer()
        {
            Universidad retorno;
            try
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Universidad.xml", out retorno);
                return retorno;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        #endregion

        #region Operadores

        public static bool operator ==(Universidad g, Alumno a)
        {
            if (Object.Equals(g.alumnos, null))
            {
                return false;
            }
            return g.alumnos.Contains(a);
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            if (Object.Equals(g.profesores, null))
            {
                return false;
            }
            return g.profesores.Contains(i);
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            bool hayAlumnos = false;
            if (!Object.Equals(g.jornada, null))
            {
                Profesor profesor = g == clase;
                Jornada nuevaJornada = new Jornada(clase, profesor);
                if (!(Object.Equals(g.alumnos, null)))
                {
                    foreach (Alumno alumno in g.alumnos)
                    {
                        if (alumno == clase)
                        {
                            nuevaJornada += alumno;
                            hayAlumnos = true;
                        }
                    }
                    if (hayAlumnos)
                    {
                        g.jornada.Add(nuevaJornada);
                    }
                }
            }
            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (!(Object.Equals(u.alumnos, null)))
            {
                if (u != a)
                {
                    u.alumnos.Add(a);
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
            }
            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (!Object.Equals(u.profesores, null))
            {
                if (u != i)
                {
                    u.profesores.Add(i);
                }
            }
            return u;
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            if (!(Object.Equals(u.profesores, null)))
            {
                foreach (Profesor profesor in u.profesores)
                {
                    if (profesor == clase)
                    {
                        return profesor;
                    }
                }
            }
            throw new SinProfesorException();
        }


        public static Profesor operator !=(Universidad u, EClases clase)
        {
            if (!(Object.Equals(u.profesores, null)))
            {
                foreach (Profesor profesor in u.profesores)
                {
                    if (profesor != clase)
                    {
                        return profesor;
                    }
                }
            }
            throw new SinProfesorException();
        }
        #endregion

    }
}
