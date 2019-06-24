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
                    EmpleadoSueldoArgs args = new EmpleadoSueldoArgs();
                    args.Sueldo = value;
                    this.limiteSueldo(this, args);

                }
                this._sueldo = value;
            }
        }


        //POLIMORFISMO
        public override string ToString()
        {
            return "Nombre: " + this._nombre + " - Legajo: " + this._legajo.ToString() + " - Sueldo: " + this._sueldo.ToString();
        }
    }
}
