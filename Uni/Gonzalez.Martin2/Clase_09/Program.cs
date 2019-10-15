using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //El Bool true dejara anexar más datos a los anteriores
            //StreamWriter writer = new StreamWriter(@"C:\miCarpeta\texto.txt");
            //StreamWriter writer = new StreamWriter(@"C:\miCarpeta\texto.txt", true);
            //A nuestros Archivos que se guardan en C, queremos que se guarden en directorios principales
            //Como Mis documentos, Escritorio, etc
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\texto.txt");
            writer.WriteLine("Hola Mundo");
            writer.WriteLine(DateTime.Now);
            writer.Close();

            //StreamReader reader = new StreamReader(@"C:\miCarpeta\texto.txt");
            //string contenido;
            //contenido = reader.ReadToEnd();
            //while((contenido = reader.ReadToEnd()) != null)
            //{
            //    Console.WriteLine(contenido);
            //    Console.ReadLine();
            //}
            //reader.Close();
            //Console.WriteLine(contenido);

            //Con el Using, no hace falta usar el .Close()

            //using (reader)
            //{
            //    string contenido;
            //    while ((contenido = reader.ReadToEnd()) != null)
            //    {
            //        Console.WriteLine(contenido);
            //        Console.ReadLine();
            //    }
            //}

            //Bloques try catch, la forma que tiene c# para capturar errores en tiempo de ejecucion (Exception)
            //En try, va a estar toda aquella linea de codigo que sea propensa a generar un error en tiempo de ejecucion
            //El bloque try, no puede estar solo, la mayoria de las veces va acompañado al menos de un bloque catch
            //try
            //{
            //    StreamWriter writer = new StreamWriter(@"C:\miCarpeta\texto.txt");
            //    writer.WriteLine("Hola Mundo");
            //    writer.WriteLine(DateTime.Now);
            //    writer.Close();
            //}
            //Solo si se provocó una exception en el try, el catch lo va a capturar
            // () posibilidad de que le pase cualquier cosa de tipo Exception o derivados de Exception
            //catch (DirectoryNotFoundException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //En este caso tengo dos catchs particulares y ahora abajo uno puro que siempre va a ir al final
            //Que me va a agarrar todos los demas casos, pero primero los particulares
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //El finally esta siempre asociado al try, independientemente que se haya ejecutado bien o con un exception
            //finally
            //{

            //}


            //El throw lanza una exception o derivado de exception al catch adecuado, si no existe ese catch,
            //burbujea hasta que llega al inicio de todo, en este caso el Main y si no encuentra un exception se rompe
            //try
            //{
            //    Program.Metodo1();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Estamos en Main: ");
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.InnerException.Message);
            //    Console.WriteLine(e.InnerException.InnerException.Message);
            //    //Quiero que se guarde donde esta el .exe de nuestra aplicación
            //    StreamWriter escritor = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\insidencias.log", true);
            //    try
            //    {
            //        escritor.WriteLine(e.StackTrace);
            //        escritor.Close();
            //    }
            //    catch (Exception a)
            //    {
            //        Console.WriteLine(a.ToString());
            //    }
            //}
            Console.ReadLine();
        }

        static void Metodo1()
        {
            try
            {
                Program.Metodo2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estamos en el catch del Metodo1: ");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
                throw new Exception("Exception en el catch1: ", e);
            }
        }

        static void Metodo2()
        {
            try
            {
                Program.Metodo3();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estamos en el catch del Metodo2: ");
                Console.WriteLine(e.Message);
                throw new Exception("Exception en el catch2: ", e);
            }
        }

        static void Metodo3()
        {
            try
            {
                Program.Metodo4();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Estamos en el catch del Metodo3: ");
                Console.WriteLine(e.Message);
            }
        }

        static void Metodo4()
        {
            Console.WriteLine("Estoy en el Metodo4: ");
            //throw new Exception("Exception en Metodo4");
            throw new Metodo4Exception("Exception en Metodo4");
        }

       
    }
}
