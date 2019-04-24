using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Martin._2A
{
  public class Grupo
  {
    private List<Mascota> _manada;
    private string _nombre;
    static EtipoManada _tipo;

    public EtipoManada Tipo
    {
      set { _tipo = value; }
    }

    static Grupo()
    {
      _tipo = EtipoManada.Unica;
    }

    private Grupo()
    {
     this._manada = new List<Mascota>();
    }

    public Grupo (string nombre) :this()
    {
      this._nombre = nombre;
    }

    public Grupo (string nombre, EtipoManada tipo) :this(nombre)
    {
      this.Tipo = tipo;
    }

    public static bool operator ==(Grupo g, Mascota m)
    {
      
          return g._manada.Contains(m);
      
    }

    public static bool operator !=(Grupo g, Mascota m)
    {
      return !(g == m);
    }

    public static Grupo operator +(Grupo g, Mascota m)
    {
      
      if (g != m)
      {
        g._manada.Add(m);
      } else
            {
                Console.WriteLine("Ya esta el " + m.ToString() + " en el grupo");
            }
            return g;
    }

    public static Grupo operator -(Grupo g, Mascota m)
    {
      if (g == m)
      {
        g._manada.Remove(m);
      }else
            {
                Console.WriteLine("No esta el " + m.ToString() + " en el grupo");
            }
            return g;
    }

    public static implicit operator string (Grupo g)
    {
        string retorno = "Grupo: " + g._nombre + " - tipo: " + _tipo + "\nIntegrantes ("+ g._manada.Count().ToString() + "): \n";
        foreach (Mascota mascota in g._manada)
        {
          retorno += mascota.ToString() + "\n";
        }
        return retorno;
      
    }
  }
}
