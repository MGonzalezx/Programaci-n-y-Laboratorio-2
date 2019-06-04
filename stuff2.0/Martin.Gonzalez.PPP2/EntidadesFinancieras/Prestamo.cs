using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
  public abstract class Prestamo
  {
    protected float monto;
    protected DateTime vencimiento;

    //PROPIEDADES
    public float Monto
    {
      get { return monto; }
    }

    //La propiedad Vencimiento deberá validar que el vencimiento sea posterior a la fecha actual antes de
    //cargar el valor, caso contrario cargarlo con la fecha actual.
    public DateTime Vencimiento
    {
      get { return vencimiento; }
      set
      {
        if(value > DateTime.Now)
        {
          this.vencimiento = value;
        }
        else
        {
          this.vencimiento = DateTime.Now;
        }
      }
    }

    //METODOS

    public Prestamo(float monto, DateTime vencimiento)
    {
      this.monto = monto;
      this.vencimiento = vencimiento;
    }

    //OrdenarPorFecha: Método estático que recibirá como parámetros 2 préstamos y retornará un
    //entero(Será utilizado en el método Sort de la lista de préstamos en la clase Financiera).
    public static int OrdenarPorFecha (Prestamo p1, Prestamo p2)
    {
      return DateTime.Compare(p1.vencimiento, p2.vencimiento);
    }

    //ExtenderPlazo: Método abstracto que recibirá un parámetro de tipo DateTime.
    public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

    //Mostrar: Método de instancia y virtual que deberá devolver una cadena que contenga los
    //atributos de la clase.
    public virtual string Mostrar()
    {
      return "Monto: " + this.monto.ToString() + " - " + "Vencimiento: " + this.vencimiento.ToString();
    }
  }

  //ENUMERADOS
  public enum TipoPrestamo
  {
    Pesos,
    Dolares,
    Todos
  }

  public enum PeriodicidadDePago
  {
    Mensual,
    Bimestral,
    Trimestral
  }
}
