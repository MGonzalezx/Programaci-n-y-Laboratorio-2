using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Clase_11.Entidades
{
    //Para que las clases que ereden de esta funcionen
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]

    public class Persona : IXML
    {  
        public string nombre;
        public string apellido;
        private int edad;
        private List<String> apodos;

        //Para que un atributo privado aparezca en los xml, tienen que tener una propiedad de escritura y lectura
        public int MiEdad { get { return this.edad; } set { this.edad = value; } }
        //Con las listas, o arrays solo se necesita una prodiedad de solo lectura
        public List<String> MisApodos { get { return this.apodos; } }

        public Persona(string nombre, string apellido, int edad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public Persona()
        {
            apodos = new List<string>();
        }

        public bool Guardar(string path)
        {
            bool retorno = false;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Persona));

                //Ahora necesitamos un objeto que sepa escribirlo en un archivo fisico
                XmlTextWriter escritor = new XmlTextWriter(path, Encoding.UTF8);

                //Con esta linea serializamos en el path deseado, al objeto
                serializador.Serialize(escritor, this);
                escritor.Close();
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;


        }

        public bool Leer(string path, out object objeto)
        {
            bool retorno = false;
            objeto = null;
            try
            {
                XmlSerializer desSerializador = new XmlSerializer(typeof(Persona));

                //un objeto que lo lea
                XmlTextReader lector = new XmlTextReader(path);

                //Lo mostramos
                objeto = (Persona)desSerializador.Deserialize(lector);
                Console.WriteLine(objeto);
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Edad: " + this.edad.ToString();
        }
    }
}