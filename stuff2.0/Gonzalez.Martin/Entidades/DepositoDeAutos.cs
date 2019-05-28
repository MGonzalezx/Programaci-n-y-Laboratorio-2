using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class DepositoDeAutos
  {
    private int _capacidadMaxima;
    private List<Auto> _lista;


    public DepositoDeAutos(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      _lista = new List<Auto>();
    }

    public static bool operator +(DepositoDeAutos d, Auto a)
    {
      bool retorno = false;
      if (d._capacidadMaxima > d._lista.Count)
      {
        d._lista.Add(a);
        retorno = true; 
      }
      return retorno;
    }

    private int GetIndice(Auto a)
    {
      for (int i = 0; i < _lista.Count ; i++) 
      {
        if (_lista[i] == a)
        {
          return i;
        }
      }
      return -1;
    }

    public static bool operator - (DepositoDeAutos d, Auto a)
    {
      int indice = d.GetIndice(a);
      if(d._lista[indice] == indice)
      {

      }
    }
  }
}
