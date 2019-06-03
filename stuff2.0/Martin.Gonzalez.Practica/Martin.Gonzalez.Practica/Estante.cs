using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Gonzalez.Practica
{
    public class Estante
    {
        //ATRIBUTOS

       // posee dos atributos, ambos
       // protegidos.Uno indicará la capacidad máxima que tendrá el estante para almacenar productos.El
       //otro es una colección genérica de tipo Producto.
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        //PROPIEDAD

        //La propiedad pública ValorEstanteTotal está asociada a la sobrecarga privada y de instancia
        //del método GetValorEstante.Reutilizar código.
        public float ValorEstanteTotal
        {
            get
            {
                return this.GetValorEstante();
            }
        }

        //CONSTRUCTORES

        //El constructor de instancia privado será el único que inicializará la lista genérica.La sobrecarga
        //pública del constructor inicializará la capacidad del estante.Reutilizar código.
        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }


        //METODOS

        //El método público GetProductos, retornará el valor asociado del atributo _productos.
        

        public List<Producto> GetProductos()
        {
            return this._productos;
        }


        private float GetValorEstante()
        {
            float valor = 0;
            foreach (Producto p in this._productos)
            {
                valor += p.Precio;
            }
            return valor;
        }

        //Método público y de instancia GetValorEstante, retornará el valor del estante de acuerdo con
        //el enumerado que recibe como parámetro
        public float GetValorEstante(ETipoProducto tipo)
        {
            float valor = 0;
            foreach (Producto p in this._productos)
            {
                if (p is Jugo && tipo == ETipoProducto.Jugo)
                {
                    valor += p.Precio;
                }
                else if (p is Gaseosa && tipo == ETipoProducto.Gaseosa)
                {
                    valor += p.Precio;
                }
                else if (p is Galletitas && tipo == ETipoProducto.Galletita)
                {
                    valor += p.Precio;
                }
                else if (p is Harina && tipo == ETipoProducto.Harina)
                {
                    valor += p.Precio;
                }
            }
            return valor;
        }

        //El método público de clase MostrarEstante, retornará una cadena con toda la información del
        //estante, incluyendo el detalle de cada uno de sus productos.Reutilizar código. 
        public static string MostrarEstante(Estante e)
        {
            string retorno = "CAPACIDAD: " + e._capacidad.ToString() + "\n";
            foreach (Producto p in e._productos)
            {
                if (p is Jugo)
                {
                    retorno += ((Jugo)p).ToString() + "\n";
                }
                else if (p is Gaseosa)
                {
                    retorno += ((Gaseosa)p).ToString() + "\n";
                }
                else if (p is Galletitas)
                {
                    retorno += ((Galletitas)p).ToString() + "\n";
                }
                else if (p is Harina)
                {
                    retorno += ((Harina)p).ToString() + "\n";
                }
            }
            return retorno;
        }


        //SOBRECARGA DE OPERADORES

        //Igualdad, retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.
        public static bool operator ==(Estante e, Producto prod)
        {
            foreach (Producto p in e._productos)
            {
                if (p == prod)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        //Adición, retornará true, si el estante posee capacidad de almacenar al menos un producto
        //más y dicho producto no se encuentra en el estante, false, caso contrario.Reutilizar código.
        public static bool operator +(Estante e, Producto prod)
        {
            if (e._capacidad > e._productos.Count && e != prod)
            {
                e._productos.Add(prod);
                return true;
            }
            return false;
        }


        //Sustracción (Estante, Producto), retornará un estante sin el producto, siempre y cuando el
        //producto se encuentre en el listado.Reutilizar código.
        public static Estante operator -(Estante e, Producto prod)
        {
            if (e == prod)
            {
                e._productos.Remove(prod);
            }
            return e;
        }


        //Sustracción(Estante, ETipoProducto), retornará un estante con todos los productos menos el
        //que coincida con el enumerado que recibe como parámetro.Reutilizar código.
        public static Estante operator -(Estante e, ETipoProducto tipo)
        {
            //if(tipo == ETipoProducto.Todos)
            //{
            //    for (int i = e._productos.Count - 1; i >= 0; i--)
            //    {
            //        e -= e._productos[i];
            //    }
            //}

            for (int i = e._productos.Count - 1; i >= 0; i--)
            {
                if ((tipo == ETipoProducto.Jugo || tipo == ETipoProducto.Todos) && e._productos[i] is Jugo)
                {
                    e._productos.Remove(e._productos[i]);
                }
                else if ((tipo == ETipoProducto.Harina || tipo == ETipoProducto.Todos) && e._productos[i] is Harina)
                {
                    e._productos.Remove(e._productos[i]);
                }
                else if ((tipo == ETipoProducto.Gaseosa || tipo == ETipoProducto.Todos) && e._productos[i] is Gaseosa)
                {
                    e._productos.Remove(e._productos[i]);
                }
                else if ((tipo == ETipoProducto.Galletita || tipo == ETipoProducto.Todos) && e._productos[i] is Harina)
                {
                    e._productos.Remove(e._productos[i]);
                }
            }
            return e;
        }
    }
}
