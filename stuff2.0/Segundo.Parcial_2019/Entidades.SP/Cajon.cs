using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  public class Cajon<T>
  {
    protected int _capacidad;
    protected List<T> _elementos;
    protected double _precioUnitario;

    //PROPIEDADES
    public List<T> Elemetos { get { return this._elementos; } }
    public double PrecioTotal { get { return (this._precioUnitario * this._elementos.Count()); } }

    //Constructores
    public Cajon()
    {
      this._elementos = new List<T>();
    }
    public Cajon(int capacidad)
    {
      this._capacidad = capacidad;
    }
    public Cajon(double preciounitario, int capacidad) : this(capacidad)
    {
      
      this._precioUnitario = preciounitario;
    }

    public override string ToString()
    {
      string cadena;
      cadena = "Capacidad maxima: " + this._capacidad + "\n";
      cadena += "Capacidad total de elemetos: " + this._elementos.Count();
      cadena += "Precio Total: " + this.PrecioTotal;
      cadena += "Listado de elementos " + typeof(T).Name + ": \n";
      foreach (T objeto in this._elementos)
      {
        cadena += objeto.ToString();
      }
      return cadena;
    }

    public static bool operator +(Cajon<T> d, T a)
    {
      bool retorno = false;
      if (d._capacidad > d._elementos.Count)
      {
        d._elementos.Add(a);
        retorno = true;
      }
      return retorno;
    }
  }
}
