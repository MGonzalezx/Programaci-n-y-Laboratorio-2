using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  interface ISerializableXML
  {
    bool SerializarXML(string );

    //bool DeserealizarXML();

    string Path { get; set; }
  }
}
