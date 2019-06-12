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
    //AGREGAR LOS USING System.Data.SqlClient y System.Data

    private SqlConnection _conexion; //Como dice el nombre, vamos a usarlo para conectarnos o
    //desconectarnos de la base de datos

    private SqlCommand _comando; // Objeto que incluye la informaciòn del comando a la base de datos

    public AccesoDatos()
    {
      //instanciamos en este constructor por default la nueva conexion.
      _conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);
    }

    //MOSTRAR LA PERSONA
    public List<Persona> TraerTodos()
    {
      //PARA PREPARARNOS PARA INICIAR LA EJECUCION
      //Instanciamos la lista que vamos a utilizar y donde estaran las personas.
      List<Persona> lista = new List<Persona>();
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text; //Que tipo de comando va a ser, en este caso de texto
      //Ponemos el comando de texto igual al que hicimos en SQL
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

    //AGREGAR PERSONA
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
        if (this._comando.ExecuteNonQuery() > 0)
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
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }

    }

    //MODIFICAR PERSONA
    public bool ModificarPersona(Persona p)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "UPDATE Padron.dbo.Personas SET nombre = '" + p.nombre + "', apellido = '" + p.apellido +
        "', edad = " + p.edad.ToString() + " WHERE id = " + p.id.ToString();

      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
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
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }

    }
    //ELIMINAR PERSONA
    public bool EliminarPersona(int n)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "DELETE FROM Padron.dbo.Personas WHERE id = " + n.ToString();
      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
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
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }
    }

    //Es independiente del proovedor de base de datos datos. No tiene SQL en su nombre.
    //No importa el origen de datos y lo va a cargar de igual manera
    public DataTable TraerTablaPersonas()
    {
      List<Persona> lista = new List<Persona>();
      //Crear un nuevo objeto de tipo datatable
      DataTable tabla = new DataTable("Personas");
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "SELECT id, nombre, apellido, edad FROM Padron.dbo.Personas";

      try
      {
        this._conexion.Open(); //Establecemos conexion
        SqlDataReader lector = this._comando.ExecuteReader();
        tabla.Load(lector);
        this._conexion.Close();
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (this._conexion.State == ConnectionState.Open)
        {
          this._conexion.Close();
        }
      }
      return tabla;
    }

  }
}
