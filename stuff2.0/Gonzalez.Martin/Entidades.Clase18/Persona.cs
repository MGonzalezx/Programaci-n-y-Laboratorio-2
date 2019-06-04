using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase18
{
  public class Persona : Humano
  {
    public string apellido;
    public string nombre;

    public Persona()
    {

    }

    public Persona(string nombre, string apellido)
    {
      this.nombre = nombre;
      this.apellido = apellido;
    }
    public override string ToString()
    {
      return base.ToString() + " - " + this.nombre + " - " + this.apellido;
    }


  }
}
