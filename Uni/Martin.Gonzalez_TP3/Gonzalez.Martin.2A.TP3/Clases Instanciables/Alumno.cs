using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #region Variables

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion

        #region Contructores

        public Alumno() : base()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos

        protected override string MostrarDatos()
        {
            string retorno = "";
            retorno += base.MostrarDatos() + "\n";
            retorno += "\nESTADO DE CUENTA: " + this.estadoCuenta.ToString() + "\n" + this.ParticiparEnClase();
            return retorno;
        }

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASES DE " + this.claseQueToma.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (!(Object.Equals(a, null)))
            {
                if (a.claseQueToma.Equals(clase) && !(a.estadoCuenta.Equals(EEstadoCuenta.Deudor)))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (!(Object.Equals(a, null)))
            {
                if (!(a.claseQueToma.Equals(clase)))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
