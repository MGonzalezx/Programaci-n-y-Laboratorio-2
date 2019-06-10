using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Entidades.Clase18;

namespace Clase18.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alumno\Desktop\hoy\Clase_19 XML\texto.xml";
            string pathDos = @"C:\Users\alumno\Desktop\hoy\Clase_19 XML\textoDos.xml";
            Persona nuevaPersona = new Persona("Perez", "Juan");
            Alumno nuevoAlumno = new Alumno();
            Profesor nuevoProfesor = new Profesor();
            nuevoProfesor.Dni = 444;
            nuevoProfesor.apellido = "S";
            nuevoProfesor.nombre = "O";
            nuevoAlumno.Legajo = 154;
            nuevoAlumno.apellido = "A";
            nuevoAlumno.nombre = "B";
            nuevoAlumno.Dni = 5465456;
            //Console.WriteLine(nuevoAlumno.ToString());
            /*
            SerializarAlumno(nuevoAlumno, path);
            Alumno alumno = DeserializarAlumno(path);
            Console.WriteLine(alumno.ToString());
            */
            /*---------------------*/
            SerializarHumano(nuevoProfesor, pathDos);
            Profesor profesor = (Profesor)DeserializarHumano(pathDos);
            Console.WriteLine(profesor.ToString());
            Console.ReadKey();
        }

        static bool SerializarAlumno(Alumno alumno, string nombreArchivo)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Alumno));
                StreamWriter streamWriter = new StreamWriter(nombreArchivo);
                xmlSerializer.Serialize(streamWriter, alumno);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        static Alumno DeserializarAlumno(string nombreArchivo)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Alumno));
            StreamReader streamReader = new StreamReader(nombreArchivo);
            Alumno retorno = (Alumno)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
            return retorno;
        }

        static bool SerializarHumano(Humano humano, string nombreArchivo)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Humano));
                StreamWriter streamWriter = new StreamWriter(nombreArchivo);
                xmlSerializer.Serialize(streamWriter, humano);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        static Humano DeserializarHumano(string nombreArchivo)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Humano));
            StreamReader streamReader = new StreamReader(nombreArchivo);
            Humano retorno = (Humano)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
            return retorno;
        }

        static bool SerializarLista(List<Humano> humanos, string nombreArchivo)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Humano));
                StreamWriter streamWriter = new StreamWriter(nombreArchivo);
                xmlSerializer.Serialize(streamWriter, humanos);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
