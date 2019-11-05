using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Variables
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores

        static Profesor()
        {
            random = new Random();
        }


        public Profesor() : base()
        {

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos

        private void _randomClases()
        {
            int numeroDeClase;
            int cantidadDeClases = 2;
            Universidad.EClases clase;
            if (!(Object.Equals(clasesDelDia, null)))
            {
                for (int i = 0; i < cantidadDeClases; i++)
                {
                    numeroDeClase = Profesor.random.Next(0, 4);
                    clase = (Universidad.EClases)Enum.ToObject(typeof(Universidad.EClases), numeroDeClase);
                    this.clasesDelDia.Enqueue(clase);
                }
            }
        }

        protected override string ParticiparEnClase()
        {
            string retorno = "";
            retorno += "CLASES DEL DIA:\n";
            if (!(Object.Equals(clasesDelDia, null)))
            {
                foreach (Universidad.EClases clase in this.clasesDelDia)
                {
                    retorno += clase.ToString() + "\n";
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += this.MostrarDatos() + "\n";
            retorno += "\n" + this.ParticiparEnClase();
            return retorno;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            if (i != null && !(Object.Equals(i.clasesDelDia, null)))
            {
                if (i.clasesDelDia.Contains(clase))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    }
}
