using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace Clase_11.Entidades
{
    public static class Serializadora
    {
        public static bool Serializar(IXML algo)
        {
           return algo.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MiArchivo.xml");
            
        }
        public static bool Deserializar(IXML algo2, out object objeto)
        {
            objeto = null;
            return algo2.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MiArchivo.xml", out objeto);
        }
    }
}
