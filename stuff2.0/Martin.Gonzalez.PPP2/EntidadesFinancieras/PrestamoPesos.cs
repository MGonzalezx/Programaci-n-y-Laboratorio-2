using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
  public class PrestamoPesos : Prestamo
  {
    private float porcentajeInteres;

    //PROPIEEDADES
    public float Interes
    {
      get { return this.CalcularInteres(); }
    }

    //METODOS
    public PrestamoPesos

    //CalcularInteres: Método privado de instancia que calculará y retornará el total del préstamo.
    //Este método será accedido a través de una propiedad de lectura llamada Interes cuyo valor será
    //utilizado en la clase Financiera dentro del método CalcularInteresGanado
    private float CalcularInteres()
    {

    }

  }
}
