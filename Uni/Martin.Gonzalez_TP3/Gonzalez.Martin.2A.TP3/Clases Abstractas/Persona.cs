using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #region Variables
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.StringToDNI = value.ToString();
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value);
            }
        }
        #endregion

        #region Constructores

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, dni.ToString(), nacionalidad)
        {

        }
        #endregion

        #region Metodos

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato < 90000000)
                {
                    return dato;
                }
            }else if (nacionalidad == ENacionalidad.Extranjero)
            {
                if (dato > 89999999 && dato < 100000000)
                {
                    return dato;
                }
            }
            throw new NacionalidadInvalidaException("La nacionalidad no coincide con el numero de DNI");
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            int resultado = 0;
            bool flag;
            if (!(String.IsNullOrEmpty(dato)))
            {
                flag = int.TryParse(dato, out resultado);
                if (!flag)
                {
                    throw new DniInvalidoException();
                }
                else
                {
                    if (resultado < 1 || resultado > 99999999)
                    {
                        throw new DniInvalidoException();
                    }
                    else
                    {
                        retorno = this.ValidarDni(nacionalidad, resultado);
                    }
                }
            }
            return retorno;
        }

        private string ValidarNombreApellido(string dato)
        {
            string retorno = "";
            if (!(String.IsNullOrEmpty(dato)))
            {
                foreach (char caracteres in dato)
                {
                    if (!Char.IsLetter(caracteres))
                    {
                        return retorno;
                    }
                }
                retorno = dato;
            }
            return retorno;
        }

        public override string ToString()
        {
            return "NOMBRE COMPLETO: " + this.nombre + ", " + this.apellido + "\nNACIONALIDAD: " + this.nacionalidad.ToString();
        }
        #endregion
    }
}
