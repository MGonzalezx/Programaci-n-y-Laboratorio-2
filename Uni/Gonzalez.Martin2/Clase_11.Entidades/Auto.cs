using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Clase_11.Entidades
{
    public class Auto : IXML
    {
        public string marca;
        public double precio;

        public Auto()
        {

        }

        public bool Guardar(string path)
        {
            bool retorno = false;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Auto));

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
                XmlSerializer desSerializador = new XmlSerializer(typeof(Auto));

                //un objeto que lo lea
                XmlTextReader lector = new XmlTextReader(path);

                //Lo mostramos
                objeto = (Auto)desSerializador.Deserialize(lector);
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
            return "Marca: " + this.marca + " - Precio: " + this.precio.ToString();
        }
    }
}
