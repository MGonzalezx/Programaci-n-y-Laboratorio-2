using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ENTIDADES.SP
{
    public class Manzana : Fruta , ISerializar , IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre { get { return "Manzana"; } }
        public string MiProvincia { get {return this._provinciaOrigen; } set { this._provinciaOrigen = value; } }

        public Manzana(string color, double peso,string provinciaOrigen) : base(color,peso)
        {
            this._provinciaOrigen = provinciaOrigen;
        }

        public override bool TieneCarozo => true;

        public override string ToString()
        {
            return base.FrutaToString() + "Provincia Origen: " + this._provinciaOrigen + "Tiene Carozo" + this.TieneCarozo; 
        }

        public bool Xml(string path)
        {
            bool retorno = false;
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Manzana));

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

        bool IDeserializar.Xml(string path, out Fruta Fruta)
        {
            bool retorno = false;
            Fruta = null;
            try
            {
                XmlSerializer desSerializador = new XmlSerializer(typeof(Manzana));

                //un objeto que lo lea
                XmlTextReader lector = new XmlTextReader(path);

                //Lo mostramos
                Fruta = (Manzana)desSerializador.Deserialize(lector);
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        
    }
}
