using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public abstract class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarca _marca;

        public EMarca Marca
        {
            get { return _marca; }
        }

        //protected string Mostrar()
        //{
        //    return this._patente + " - " + this._cantRuedas.ToString() + " - " + this._marca;
        //}

        public Vehiculo(string patente, byte cantidadRuedas, EMarca marca)
        {
            this._patente = patente;
            this._cantRuedas = cantidadRuedas;
            this._marca = marca;
        }

        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return (vehiculoUno._patente.Equals(vehiculoDos._patente) && vehiculoUno._marca == vehiculoDos._marca);
        }

        public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return !(vehiculoUno == vehiculoDos);
        }

        ///CLASE 10///
        public override string ToString()
        {
            return this._patente + " - " + this._cantRuedas.ToString() + " - " + this.Marca.ToString();
        }

        public abstract double Precio { get; set; }

        public abstract double CalcularPrecioConIVA();
    }
}
