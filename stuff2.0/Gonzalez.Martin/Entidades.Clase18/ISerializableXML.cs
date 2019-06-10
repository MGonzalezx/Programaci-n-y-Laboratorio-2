using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase18
{
    interface ISerializableXML
    {
        bool SerializarXML();

        //bool DeserealizarXML();

        string Path { get; set; }
    }
}
