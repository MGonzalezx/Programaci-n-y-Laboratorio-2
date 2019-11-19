using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;


namespace Clase_13.MisEntidades
{
    public class PersonitaExterna : PersonaExterna
    {
        #region Propiedades

        public string MiNombreExterno { get {return base._nombre ; } }
        public string MiApellidoExterno { get { return base._apellido; } }
        public int MiEdadExterno { get { return base._edad; } }
        public ESexo MiSexoExterno { get { return base._sexo; } }
        #endregion

        #region Constructores

        public PersonitaExterna(string nombre, string apellido, int edad, ESexo sexo) : base(nombre,apellido,edad,sexo)
        {

        }

        #endregion

        #region Metodos

        public string ObtenerInfo()
        {
            return "Nombre: " + this._nombre + " - Apellido: " + this._apellido + " - Edad: " + this._edad.ToString()
                + " - Sexo: " + this._sexo;
        }

        #endregion


    }
}
