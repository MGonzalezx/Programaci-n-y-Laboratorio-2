using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Martin._2A
{
   public class Perro : Mascota
  {
    private int edad;
    private bool esAlfa;

    public Perro (string nombre, string raza) : this(nombre, raza, 0, false)
    {

    }
    public Perro(string nombre, string raza, int edad, bool esAlfa) :  base(nombre, raza)
    {
      this.edad = edad;
      this.esAlfa = esAlfa;
    }

    protected override string Ficha()
    {
            string retorno;
      if (this.esAlfa)
      {
        retorno = this.DatosCompletos() + " alfa de la manada, edad  " + this.edad;
      }
      else
      {
        retorno = this.DatosCompletos() + ", edad " + this.edad;
      }
            return retorno;
    }

      public static bool operator ==(Perro p1, Perro p2)
    {
      if( (p1._nombre.Equals(p2._nombre) && p1._raza.Equals(p2._raza) && p1.edad.Equals(p2.edad)))
            {
                return true;
            }else
            {
                return false;
            }
    }
    public static bool operator !=(Perro p1, Perro p2)
    {
      return  !(p1 == p2);
    }

    public static explicit operator int (Perro p)
    {
      return p.edad;
    }

    public override string ToString()
    {
            return this.Ficha();
    }

    public override bool Equals(object obj)
    {

      if (obj is Perro)
      {
        return (Perro)obj == this;
      }
      else
      {
        return false;
      }
    }
  }
  }

