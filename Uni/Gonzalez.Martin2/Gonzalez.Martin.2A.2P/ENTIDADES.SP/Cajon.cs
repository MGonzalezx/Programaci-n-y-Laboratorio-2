using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace ENTIDADES.SP
{
    public class Cajon<T> : ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public delegate void DelegadoEventoPrecio(double precio);
        public event DelegadoEventoPrecio MiEvento;

        public List<T> Elementos { get { return this._elementos; } }
        public double PrecioTotal
        {
            get
            {
                double precioTotal = this._precioUnitario * this._elementos.Count;
                   if (precioTotal > 55)
                {
                    this.MiEvento(precioTotal);

                }
                return precioTotal;
            }

            set
            {

            }


        }


        public Cajon()
        {
            _elementos = new List<T>();
        }
        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            string generico = " ";
            string DepositoGenerico = " ";
            DepositoGenerico = "Capacidad: " + this._capacidad.ToString() + "\n Cantidad Total Elementos: " + this._elementos.Count.ToString() +
              "\n Precio Total: " + this.PrecioTotal.ToString() + "\n" + "Listado Del cajon de:" + typeof(T).Name + ":\n";
            foreach (T genericos in this._elementos)
            {

                generico += genericos.ToString() + "\n";

            }

            return DepositoGenerico + generico;
        }



        public bool Xml(string path)
        {
            bool retorno = false;
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Cajon<T>));

                //Ahora necesitamos un objeto que sepa escribirlo en un archivo fisico
                XmlTextWriter escritor = new XmlTextWriter(path, Encoding.UTF8);

                //Con esta linea serializamos en el path deseado, al objeto
                serializador.Serialize(escritor, this);
                escritor.Close();
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public static Cajon<T> operator +(Cajon<T> d, T a)
        {


            if (d._elementos.Count < d._capacidad)
            {
                d._elementos.Add(a);

            }
            else
            {
                throw new CajonLlenoException();
            }
            return d;


        }
    }
}
