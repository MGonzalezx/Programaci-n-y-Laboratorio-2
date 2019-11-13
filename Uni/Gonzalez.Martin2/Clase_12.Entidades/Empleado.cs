using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12.Entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        //Que delegado va a estar asociado al evento
        public event LimiteSueldoDelegado LimiteSueldo;
        public event LimiteSueldoMejoradoDel LimiteSueldoMejorado;

        #region Propiedades

        public string MiNombre { get { return this.nombre; } set { this.nombre = value; } }
        public string MiApellido { get { return this.apellido; } set { this.apellido = value; } }
        public int MiLegajo { get { return this.legajo; } set { this.legajo = value; } }
        //Al momento de querer agregar un salario que no nos guste, se dispare el evento
        //Agregamos logica antes del this.sueldo = value
        public double MiSueldo
        {
            get { return this.sueldo; }
            set
            {
                try
                {

                    if (value > 18000 && value <= 30000)
                    {
                        this.LimiteSueldo(value, this);
                    }
                    else if (value > 30000)
                    {
                        EmpleadoEventArgs miEmpleadoEventArgs = new EmpleadoEventArgs();
                        miEmpleadoEventArgs.SueldoAsignar = value;
                        this.LimiteSueldoMejorado(this, miEmpleadoEventArgs);
                    }
                    else
                    {
                        this.sueldo = value;
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        #region Constructores

        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Legajo: " + this.legajo.ToString() +
                " - Sueldo: " + this.sueldo.ToString() + "\n";
        }

        #endregion

    }
}
