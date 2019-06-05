using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
  public class Deposito
  {
    public List<Producto> listaProducto;
    public sbyte productos;

    public Deposito()
    {
      this.listaProducto = new List<Producto>(3);
    }
    public Deposito(sbyte productos) : this()
    {
      this.productos = productos;
    }

    //public static bool operator + (Deposito p1, Deposito p2)
    //{
      
    //}
      
    

  }
}
