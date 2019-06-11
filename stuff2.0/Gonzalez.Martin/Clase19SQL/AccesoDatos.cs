using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Clase19SQL
{
  public class AccesoDatos
  {
    private SqlConnection _conexion;
    private SqlCommand _comando;

    public  AccesoDatos()
    {
      _conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);
    }

    public List<Persona> TraerTodos()
    {
      //PARA PREPARARNOS PARA INICIAR LA EJECUCION
      List<Persona> lista = new List<Persona>();
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "SELECT id, nombre, apellido, edad FROM Padron.dbo.Personas";

      //EMPEZAMOS A HACER LA EJECUCUONES
      try
      {
      
        this._conexion.Open(); //Establecemos conexion
        SqlDataReader lector = this._comando.ExecuteReader();
        while (lector.Read())
        {
          Persona p = new Persona((int)lector[0], (string)lector[1], (string)lector[2], (int)lector[3]);
          lista.Add(p);
          
        }
        this._conexion.Close();
      }
      catch (Exception)
      {
        throw; 
      }
      return lista;
    }

    public bool AgregarPersona(Persona p)
    {
      this._comando = new SqlCommand();
     this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "INSERT INTO Padron.dbo.Personas (nombre, apellido, edad) VALUES" + "('" + p.nombre + "','"
        + p.apellido + "'," + p.edad.ToString() + ")";

      try
      {
        this._conexion.Open(); //Establecemos conexion
        if(this._comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
        else
        {
          return false;
        }
        
      }
      catch (Exception)
      {
        throw;
      }

    }
  }
}
