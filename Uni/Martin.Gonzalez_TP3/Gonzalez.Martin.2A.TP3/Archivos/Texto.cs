using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivos<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            if (!string.IsNullOrEmpty(archivo) && !string.IsNullOrEmpty(datos))
            {
                try
                {
                    StreamWriter escritor = new StreamWriter(archivo);
                    foreach (char c in datos)
                    {
                        escritor.Write(c);
                        if (c == '\n')
                        {
                            escritor.WriteLine();
                           
                        }
                    }
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

        public bool Leer(string archivo, out string datos)
        {
            if (!string.IsNullOrEmpty(archivo))
            {
                try
                {
                    string retorno = "";
                    StreamReader lector = new StreamReader(archivo);
                    while (!lector.EndOfStream)
                    {
                        retorno += lector.ReadLine();
                    }
                    lector.Close();
                    datos = retorno;
                    return true;
                }
                catch (Exception e)
                {
                    throw new ArchivosException(e);
                }
            }
            datos = "";
            return false;
        }
    }
}
