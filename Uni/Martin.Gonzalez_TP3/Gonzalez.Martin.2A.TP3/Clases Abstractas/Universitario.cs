using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores

        public Universitario() : base()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos

        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                return (Universitario)obj == this;
            }
            return false;
        }

        protected virtual string MostrarDatos()
        {
            string retorno = "";
            retorno += base.ToString() + "\n";
            retorno += "\nLEGAJO NUMERO: " + this.legajo.ToString();
            return retorno;
        }

        protected abstract string ParticiparEnClase();

        #endregion

        #region Operadores

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if (Object.Equals(pg1, null) && Object.Equals(pg2, null))
            {
                retorno = true;
            }
            else if (!(Object.Equals(pg1, null)) && !(Object.Equals(pg2, null)))
            {
                if (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
