using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Cartuchera<Utiles> 
    {
        protected int capacidad;
        protected List<Utiles> elementos;
        [XmlIgnore]
        public EventoPrecios EventoPrecio;
        public delegate void EventoPrecios(double precio, Cartuchera<Utiles> utiles);

        public List<Utiles> Elementos { get { return this.elementos; } }
        public int PrecioTotal { get
            {
                double precioTotal = 
                if (precioTotal > 85)
                {
                    this.EventoPrecio(precioTotal, this);

                }
                return precioTotal;
            }

        }

        public Cartuchera()
        {
            this.elementos = new List<Utiles>();
        }

        public Cartuchera(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public override string ToString()
        {
            string generico = " ";
            string DepositoGenerico = " ";
            DepositoGenerico = "Capacidad: " + this.capacidad.ToString() + "\n Cantidad Actual Elementos: " + this.elementos.Count.ToString() +
              "\n Precio Total: " + this.PrecioTotal.ToString() + "\n" + "Listado Del cajon de:" + typeof(Utiles).Name + ":\n";
            foreach (Utiles genericos in this.elementos)
            {

                generico += genericos.ToString() + "\n";

            }

            return DepositoGenerico + generico;
        }

        public static Cartuchera<Utiles> operator +(Cartuchera<Utiles> d, Utiles a)
        {


            if (d.elementos.Count < d.capacidad)
            {
                d.Elementos.Add(a);

            }
            else
            {
                throw new CartucheraLlenaException();
            }
            return d;


        }

    }
}
