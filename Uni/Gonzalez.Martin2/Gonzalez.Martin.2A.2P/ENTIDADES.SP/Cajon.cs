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

        public List<T> Elementos { get { return this._elementos; } }
        public double PrecioTotal { get { return this._precioUnitario * _elementos.Count; }

            set {
                if (value > 18000 && value <= 30000)
                {
                    LimitePrecioFinal(value, this);
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

        public static bool operator +(Cajon<T> d, T a)
        {
            try
            {

                bool retorno = false;
                if (d._elementos.Count < d._capacidad)
                {
                    d._elementos.Add(a);
                    return retorno = true;
                }
                return retorno;
            }
            catch(Exception )
            {
                throw new CajonLlenoException();
            }
            
            
        }
    }
}
