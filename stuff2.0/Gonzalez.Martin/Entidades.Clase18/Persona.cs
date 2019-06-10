using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.Clase18
{
    public class Persona : Humano, ISerializableXML
    {
        public string apellido;
        public string nombre;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Path
        {
            get { return this.Path; }
            set { this.Path = value; }
        }

        public void Deserializar()
        {
            throw new NotImplementedException();
        }

        public bool SerializarXML()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                StreamWriter streamWriter = new StreamWriter(this.Path);
                xmlSerializer.Serialize(streamWriter, this);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public bool DeserealizarXML()
        //{

        //}
        public override string ToString()
        {
            return base.ToString() + " - " + this.nombre + " - " + this.apellido;
        }
       

    }
}
