using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Entidades
{
    public class Lapiz : Utiles, ISerializa, IDeserializa
    {
        

        public ConsoleColor color;
        public ETipoTrazo trazo;

        public Lapiz() : this(ConsoleColor.Black,ETipoTrazo.Fino, "vacio", 0)
        {

        }

        public Lapiz( ConsoleColor color, ETipoTrazo trazo, string marca, double precio) : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public override bool PreciosCuidados => true;

        public string Path => "Gonzalez.Martin.lapiz.xml";

        public override string ToString()
        {
            return base.ToString() + " Color: " +this.color + " Trazo: "+ this.trazo;
        }

        public bool  Xml()
        {
            bool sePudo = false;
            XmlSerializer serializador = new XmlSerializer(typeof(Lapiz));

            try
            {
                using (TextWriter escritor = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + this.Path))
                {
                    serializador.Serialize(escritor, this);
                    sePudo = true;
                }
            }
            catch (Exception error)
            {
                sePudo = false;
               
            }

            return sePudo;
        }

        bool IDeserializa.Xml(out Lapiz lapiz)
        {
            bool sePudo = false;
            lapiz = null;
            XmlSerializer serializador = new XmlSerializer(typeof(Lapiz));

            try
            {
                using (TextReader lector = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + this.Path))
                {
                    lapiz = (Lapiz)serializador.Deserialize(lector);
                    sePudo = true;
                }
            }
            catch (Exception error)
            {
                sePudo = false;
               
            }

            return sePudo;
        }
    }
}
