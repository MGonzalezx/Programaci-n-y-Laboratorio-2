using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para usar XML usamos el siguiente using
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Clase_11.Entidades;

namespace Clase_11.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona miPersona = new Persona("Juan", "Perez",10);
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Persona.xml";
            ////vamos a necesitar un objeto que sepa serializar cualquier objeto
            ////Para usar el type de una clase hacemos typeof()
            ////Para que no tire una Exception necesita una clase con constructor por default y publica
            //try
            //{
            //    XmlSerializer serializador = new XmlSerializer(typeof(Persona));

            //    //Ahora necesitamos un objeto que sepa escribirlo en un archivo fisico
            //    XmlTextWriter escritor = new XmlTextWriter(path, Encoding.UTF8);

            //    //El TextWriter seria con el System.IO
            //    //TextWriter escritor2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Persona.xml");

            //    //Con esta linea serializamos en el path deseado, al objeto
            //    serializador.Serialize(escritor, miPersona);
            //    escritor.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            ////Ahora lo vamos a des-Serializar
            //Persona miPersonaSola = new Persona();
            //try
            //{
            //    XmlSerializer desSerializador = new XmlSerializer(typeof(Persona));

            //    //un objeto que lo lea
            //    XmlTextReader lector = new XmlTextReader(path);
            //    //TextReader lector2 = new StreamReader(path);

            //    miPersonaSola = (Persona)desSerializador.Deserialize(lector);
            //    Console.WriteLine(miPersonaSola);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Creamos un lista generica de personas
            //List<Persona> listaPersona = new List<Persona>();
            //Persona miPersona1 = new Persona("Martin", "Gonzalez", 10);
            //miPersona1.MisApodos.Add("Tincho");
            //Persona miPersona2 = new Persona("Juana", "Pereza", 12);
            //miPersona2.MisApodos.Add("Dormi");
            //Persona miPersona3 = new Persona("Dudis", "Fludis", 13);
            //miPersona3.MisApodos.Add("Pocho");

            //string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaPersonas.xml";

            //listaPersona.Add(miPersona1);
            //listaPersona.Add(miPersona2);
            //listaPersona.Add(miPersona3);

            //try
            //{
            //    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));

            //    //Ahora necesitamos un objeto que sepa escribirlo en un archivo fisico
            //    XmlTextWriter escritor = new XmlTextWriter(path2, Encoding.UTF8);

            //    //Con esta linea serializamos en el path deseado, al objeto
            //    serializador.Serialize(escritor, listaPersona);
            //    escritor.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            ////Ahora lo vamos a des-Serializar
            //List<Persona> miListaPersonaSola = new List<Persona>();
            //try
            //{
            //    XmlSerializer desSerializador = new XmlSerializer(typeof(List<Persona>));

            //    //un objeto que lo lea
            //    XmlTextReader lector = new XmlTextReader(path2);

            //    //Lo mostramos
            //    miListaPersonaSola = (List<Persona>)desSerializador.Deserialize(lector);
            //    foreach (Persona personita in miListaPersonaSola)
            //    {
            //        Console.WriteLine(personita);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //CREAR LIST PERSONAS
            //AGREGAR PERSONAS, EMPLEADO Y ALUMNOS
            // SERIALIZAR LA LISTA
            // OBSERVAR CONTENIDO DEL ARCHIVO .XML
            //DESERIALIZAR LA LISTA

            List<Persona> miListaPersona = new List<Persona>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MiLista.xml";

            Persona miPersona1 = new Persona("Martin", "Gonzalez", 10);
            Persona miPersona2 = new Persona("Juana", "Pereza", 12);
            Persona miPersona3 = new Persona("Dudis", "Fludis", 13);
            Empleado miEmpleado1 = new Empleado("Ricardo", "Martinez", 40, 111, 1000);
            Alumno miAlumno1 = new Alumno("Dudisa", "Fludisa", 20, 10);

            miListaPersona.Add(miPersona1);
            miListaPersona.Add(miPersona2);
            miListaPersona.Add(miPersona3);
            miListaPersona.Add(miEmpleado1);
            miListaPersona.Add(miAlumno1);

            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));

                //Ahora necesitamos un objeto que sepa escribirlo en un archivo fisico
                XmlTextWriter escritor = new XmlTextWriter(path, Encoding.UTF8);

                //Con esta linea serializamos en el path deseado, al objeto
                serializador.Serialize(escritor, miListaPersona);
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Ahora lo vamos a des-Serializar
            List<Persona> miListaPersonaSola = new List<Persona>();
            try
            {
                XmlSerializer desSerializador = new XmlSerializer(typeof(List<Persona>));

                //un objeto que lo lea
                XmlTextReader lector = new XmlTextReader(path);

                //Lo mostramos
                miListaPersonaSola = (List<Persona>)desSerializador.Deserialize(lector);
                foreach (Persona personita in miListaPersonaSola)
                {
                    Console.WriteLine(personita);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}