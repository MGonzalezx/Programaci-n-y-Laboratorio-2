using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadeFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        //PROPIEDADES
        public float InteresesEnDolares
        {
            get { return this.CalcularInteresGanado(TipoPrestamo.Dolares); }
        }

        public float InteresesEnPesos
        {
            get { return this.CalcularInteresGanado(TipoPrestamo.Pesos); ; }
        }

        public float InteresesTotales
        {
            get { return this.CalcularInteresGanado(TipoPrestamo.Todos); }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get { return this.listaDePrestamos; }
        }

        public string RazonSocial
        {
            get { return this.razonSocial; }
        }

        //CONSTRUCTORES
        //Constructor: Recibirá la razón social y luego inicializará la lista genérica en el constructor por
        //defecto el cual deberá ser private
        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        //SOBRECARGA DE OPERADORES
        //Sobrecarga de operadores:
        //a.Se deberán sobrecargar el operador ''+'' para que permitirá cargar un préstamo a la financiera
        //b.El operador ''=='' que será utilizado para validar que el que un mismo préstamo no sea cargado
        //más de una vez en la financiera.
        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;
            foreach (Prestamo p in financiera.listaDePrestamos)
            {
                if (p == prestamo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if (financiera != prestamoNuevo)
            {
                financiera.listaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }

        //Conversión explícita a string retornará una cadena que contendrá la razón social, los intereses
        //totales ganados por préstamos otorgados, los intereses por préstamos en pesos y por préstamos
        //en dólares y el detalle de cada préstamo ordenados por fecha(se deberá utilizar StringBuilder
        //para armar la cadena a devolver).
        //CONVERSION EXPLICITA
        public static explicit operator string(Financiera financiera)
        {
            String retorno = financiera.razonSocial + "\n";
            retorno += "Intereses totales: " + financiera.InteresesTotales + "\n";
            retorno += "Intereses por prestamos en pesos: " + financiera.InteresesEnPesos + "\n";
            retorno += "Intereses por prestamos en dolares: " + financiera.InteresesEnDolares + "\n";
            financiera.OrdenarPrestamos();
            foreach (Prestamo p in financiera.listaDePrestamos)
            {
                if (p is PrestamoPesos)
                {
                    retorno += ((PrestamoPesos)p).Mostrar();
                }
                else
                {
                    retorno += ((PrestamoDolar)p).Mostrar();
                }
            }
            return retorno;
        }

        //METODOS

        //CalcularInteresGanado: Método privado que recibe un Enumerado de tipo TipoDePrestamo y
        //retornará el valor equivalente a la suma de intereses entre todos los préstamos(invocar a la
        //propiedad Interes de la clase PrestamoPesos o PrestamoDolar según el tipo de préstamo
        //evaluado).
        private float CalcularInteresGanado(TipoPrestamo tipoPrestamos)
        {
            float sumaInteresesPesos = 0;
            float sumaInteresesDolares = 0;
            foreach (Prestamo prest in this.listaDePrestamos)
            {
                if (prest is PrestamoDolar)
                {
                    sumaInteresesDolares += ((PrestamoDolar)prest).Interes;
                }
                else if (prest is PrestamoPesos)
                {
                    sumaInteresesPesos += ((PrestamoPesos)prest).Interes;
                }
            }
            if (tipoPrestamos == TipoPrestamo.Dolares)
            {
                return sumaInteresesDolares;
            }
            else if (tipoPrestamos == TipoPrestamo.Pesos)
            {
                return sumaInteresesPesos;
            }
            else
            {
                return sumaInteresesDolares + sumaInteresesPesos;
            }
        }

        //Mostrar: Método estático que devolverá una cadena. Deberá reutilizar la conversión explicita
        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        //OrdenarPrestamos: Deberá ordenar por fecha de vencimiento la lista de préstamos
        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
    }
}
