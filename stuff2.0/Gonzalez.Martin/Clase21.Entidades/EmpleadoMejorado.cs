using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase21.Entidades
{
  public class EmpleadoMejorado
  {
    private string _nombre;
    private int _legajo;
    private float _sueldo;
    //PALABRA RESERVADA EVENT
    public event DelSueldo limiteSueldo;
    //Necesitamos que el event se dispare.

    //Eventos, atributos, propiedades, metodos

    //PROPIEDADES
    public string Nombre
    {
      get { return this._nombre; }
      set { this._nombre = value; }
    }

    public int Legajo
    {
      get { return this._legajo; }
      set { this._legajo = value; }
    }

    public float Sueldo
    {
      get { return this._sueldo; }
      set
      {
        if (value > 12000)
        {
          
        }
        this._sueldo = value;
      }
    }


    //POLIMORFISMO
    public override string ToString()
    {
      return this._nombre + " - " + this._legajo.ToString() + " - " + this._sueldo.ToString();
    }
  }
}
