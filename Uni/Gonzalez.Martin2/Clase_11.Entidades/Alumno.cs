using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11.Entidades
{
    public class Alumno : Persona
    {
        public double nota;

        public Alumno(string nombre, string apellido, int edad, int nota) : base(nombre, apellido, edad)
        {
            this.nota = nota;
            
        }
        public Alumno()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " - Nota: " + this.nota.ToString();
        }
    }
}
