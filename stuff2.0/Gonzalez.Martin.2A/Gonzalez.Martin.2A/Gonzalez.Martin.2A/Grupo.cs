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
    private static EtipoManada _tipo;

    //public List<Mascota> MisMascotas
    //{
    //  get { return _manada; }
    //}

    public EtipoManada Tipo
    {
      set { Tipo = _tipo; }
    }
    static Grupo()
    {
      _tipo = EtipoManada.Unica;
    }

    private Grupo()
    {
     this._manada = new List<Mascota>();
    }

    public Grupo (string nombre) 
    {
      this._nombre = nombre;
    }

    public Grupo (string nombre, EtipoManada tipo) :this(nombre)
    {
      _tipo = tipo;
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
      }
      return g;
    }

    public static Grupo operator -(Grupo g, Mascota m)
    {
      if (g == m)
      {
        g._manada.Remove(m);
      }
      return g;
    }

    public static implicit operator string (Grupo g)
    {
        string retorno = "Grupo: " + g + " - " + "tipo: " + _tipo + "\nIntegrantes: ("+ g._manada.Count + ") \n";
        foreach (Mascota mascota in g._manada)
        {
          retorno += mascota.ToString() + "\n";
        }
        return retorno;
      
    }
  }
}
