using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Threading;

namespace Clase_13.MisEntidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        #region Propiedades

        public string MiNombre { get {return this.nombre; } }
        public string MiApellido { get { return this.apellido; } }
        public int MiDni { get { return this.dni; } }

        #endregion

        #region Constructores

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        #endregion

        #region Metodos

        public string ObtenerInfo()
        {
            return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Dni: " + this.dni.ToString();
        }

        public string ObtenerInfoBD()
        {
            return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Edad: " + this.dni.ToString();
        }
        #endregion
    }
}
