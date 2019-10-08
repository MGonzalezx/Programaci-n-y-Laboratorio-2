using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Alumno
    {
        #region Variables
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;
        #endregion

        #region Propiedades
        public string Apellido { get { return this._apellido; } }
        public int Legajo { get { return this._legajo; } }
        public string Nombre { get { return this._nombre; } }
        public float Nota
        {
            get { return this._nota; }
            set { this._nota = value; }
        }
        #endregion

        #region Constructores
        public Alumno(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;

        }
        public Alumno(string nombre, string apellido, int legajo) : this(legajo, nombre, apellido)
        {

        }
        public Alumno(string apellido, int legajo, string nombre) : this(legajo, nombre, apellido)
        {

        }
        public Alumno(int legajo) : this(legajo, "Sin Nombre", "Apellido")
        {

        }
        public Alumno() : this(0, "Sin Nombre", "Apellido")
        {

        }

        #endregion

        #region Metodos
        private string Mostrar()
        {
            return this._apellido + ", " + this._nombre + " - Legajo: " + this._legajo.ToString() + " - Nota: " + this._nota.ToString() + "\n\n";
        }

        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return (a1._legajo == a2._legajo);
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
