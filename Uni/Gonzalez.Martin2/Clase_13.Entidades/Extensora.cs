using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Clase_13.MisEntidades
{
    public static class Extensora
    {
        //this màs la clase a la cual la voy a asociar
        public static string ObtenerInfo(this PersonaExternaSellada p)
        {
            return "Nombre: " + p.Nombre + " - Apellido: " + p.Apellido + " - Edad: " + p.Edad.ToString()
                 + " - Sexo: " + p.Sexo;
        }

        public static bool EsNulo(this object objeto)
        {
            return object.Equals(objeto, null);
        }

        public static List<Persona> ObtenerListadoBD(this Persona persona)
        {
            List<Persona> miLista = new List<Persona>();
            SqlConnection connection;
            SqlCommand comando;
            SqlDataReader lector;
            try
            {

                connection = new SqlConnection(Properties.Settings.Default.ConectorBD);
                connection.Open();
                comando = new SqlCommand();
                comando.Connection = connection;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT TOP 1000[id] ,[nombre] ,[apellido] ,[edad] FROM[personas_bd].[dbo].[personas]";
                lector = comando.ExecuteReader();
                while (lector.Read() != false)
                {
                    Persona nuevaPersonita = new Persona(lector[1].ToString(), lector[2].ToString(), (int)lector[3]);
                    miLista.Add(nuevaPersonita);
                }


                lector.Close();
                connection.Close();
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

            return miLista;
            
        }
    }
}
