using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            if (!string.IsNullOrEmpty(archivo) && !Object.Equals(datos, null))
            {
                
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8);
                    serializador.Serialize(escritor, datos);
                    escritor.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw new ArchivosException(e);
                   
                }
               
            }
            return false;
        }

        public bool Leer(string archivo, out T datos)
        {
            datos = default(T);
            if (!string.IsNullOrEmpty(archivo))
            {
                try
                {
                    XmlSerializer desSerializador = new XmlSerializer(typeof(T));
                    XmlTextReader lector = new XmlTextReader(archivo);
                    datos = (T)desSerializador.Deserialize(lector);
                    lector.Close();
                    return true;
                }
                catch(Exception e)
                {
                    throw new ArchivosException(e);
                }
            }
            return false;
        }
    }
}
