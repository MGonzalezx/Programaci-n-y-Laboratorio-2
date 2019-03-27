using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.entidades
{
 public class Cosa
  {
    public int entero;
    public string cadena;
    public DateTime fecha;

    public string Mostrar()
    {
      return this.entero.ToString() + "-" + this.cadena.ToString() + "-" +this.fecha.ToString(); 
    }

    public static string Mostrar(Cosa objeto)
    {
      return objeto.Mostrar();
        //cosa.entero.ToString() + "-" + cosa.cadena.ToString() + "-" + cosa.fecha.ToString();
    }

    //public void EstablecerValor(int a)
    //{

    //}
    //public void EstablecerValor(int a, string b)
    //{

    //}
    public void EstablecerValor(int x, string b, DateTime c)
    {
      this.entero = x;
      this.cadena = b;
      this.fecha = c;

    }

    public Cosa()
    {
      this.entero = 10;
      this.fecha = DateTime.Now;
      this.cadena = "Sin valor";
    }

    public Cosa(int a) : this()
    {
      this.entero = a;
      //this.fecha = DateTime.Now;
      //this.cadena = "Sin valor";
    }

    public Cosa(int a, DateTime b) : this(a)
    {
      //this.entero = a;
      this.fecha = b;
      //this.cadena = "Sin valor";
    }

    public Cosa(int a, DateTime b, string c) : this(a,b)
    {
      //this.entero = a;
      //this.fecha = b;
      this.cadena = c;
    }
  }
}
