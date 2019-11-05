using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{
    [Serializable]
    public class Jornada
    {
        #region Variables
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades

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

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion


        #region Constructores
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            string retorno = "";
            retorno += "CLASE DE " + this.clase.ToString() + " POR " + this.instructor.ToString() + "\n";
            retorno += "ALUMNOS:\n";
            foreach (Alumno alumno in this.alumnos)
            {
                retorno += alumno.ToString() + "\n";
            }
            retorno += "<------------------------------------------------>";
            return retorno;
        }

        public static bool Guardar(Jornada jornada)
        {
            bool retorno = false;
            if (!Object.Equals(jornada, null))
            {
                string informacion = jornada.ToString();
                Texto miTexto = new Texto();
                miTexto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Jornada.txt", informacion);
                retorno = true;
            }
            return retorno;
        }

        public static string Leer()
        {
            string informacion = "";
            Texto miTexto = new Texto();
            miTexto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Jornada.txt", out informacion);
            return informacion;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Jornada j, Alumno a)
        {
            if (!(Object.Equals(j, null)) && !(Object.Equals(j.alumnos, null)))
            {
                return j.alumnos.Contains(a);
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (!(Object.Equals(j, null)) && !(Object.Equals(j.alumnos, null)))
            {
                if (j != a)
                {
                    j.alumnos.Add(a);
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
            }
            return j;
        }

        #endregion

    }
}
