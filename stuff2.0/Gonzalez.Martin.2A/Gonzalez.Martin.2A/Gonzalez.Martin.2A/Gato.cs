using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Martin._2A
{
  public class Gato : Mascota
  {

    public Gato(string nombre, string raza) : base(nombre, raza)
    {

    }

    protected override string Ficha()
    {
      return this._nombre + "   " + this._raza;
    }

    public static bool operator ==(Gato g1, Gato g2)
    {
      return (g1._nombre.Equals(g2._nombre) && g1._raza.Equals(g2._raza));
    }
    public static bool operator !=(Gato g1, Gato g2)
    {
      return !(g1 == g2);
    }

    public override string ToString()
    {
      return base.DatosCompletos();
    }

    public override bool Equals(object obj)
    {
      
        if(obj is Gato)
      {
        return (Gato)obj == this;
      }else
      {
        return false;
      }
    }



  }
}
