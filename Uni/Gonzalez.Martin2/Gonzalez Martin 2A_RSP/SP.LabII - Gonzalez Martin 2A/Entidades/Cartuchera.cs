using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        protected int capacidad;
        protected List<T> elementos;

        public delegate void DelegadoEventoPrecio(object sender, EventArgs e);
        public event DelegadoEventoPrecio EventoPrecio;

        public List<T> Elementos { get { return this.elementos; } }
        public double PrecioTotal { get
            {
                double precioTotal = 0;
                foreach (T elemento in this.Elementos)
                {
                    precioTotal += elemento.precio;
                }

                return precioTotal;
            }

        }

        public Cartuchera()
        {
            this.elementos = new List<T>();
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

        public static Cartuchera<T> operator +(Cartuchera<T> cartuchera, T util)
        {


            if (cartuchera.capacidad > cartuchera.Elementos.Count)
            {
                cartuchera.Elementos.Add(util);
                if (cartuchera is Cartuchera<Goma>)
                {
                    if (cartuchera.PrecioTotal > 85)
                    {
                        cartuchera.EventoPrecio(cartuchera, new EventArgs());
                    }
                }
            }
            else
            {
                throw new CartucheraLlenaException();
            }

            return cartuchera;


        }

    }
}
