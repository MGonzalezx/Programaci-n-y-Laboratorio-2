using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11.Entidades
{
    public class Empleado : Persona
    {
        public int legajo;
        public double sueldo;

        public Empleado(string nombre, string apellido, int edad,int legajo, double sueldo) : base(nombre, apellido, edad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }
        public Empleado()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " - Legajo: " + this.legajo.ToString() + " - Sueldo: " + this.sueldo.ToString();
        }
    }
}
