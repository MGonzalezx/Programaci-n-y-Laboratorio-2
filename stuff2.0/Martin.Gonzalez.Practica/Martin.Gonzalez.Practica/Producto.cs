using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Gonzalez.Practica
{
    public abstract class Producto
    {
            //  Todos sus atributos son protegidos.Posee sólo un constructor de instancia.
            
            

        //ATRIBUTOS
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;


        //PROPIEDADES
        //Contendrá una propiedad abstracta de sólo lectura llamada CalcularCostoDeProduccion. Retornará un float

        public abstract float CalcularCostoDeProduccion
        { get; }

        //La propiedad Marca, retornará el valor correspondiente del atributo _marca.
        public EMarcaProducto Marca
        {
            get { return _marca; }
        }

        //La propiedad Precio,retornará el valor asociado al atributo _precio
        public float Precio
        {
            get { return _precio; }
        }

        //CONSTRUCTOR
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }



        //OPERADORES
        //El método privado de clase MostrarProducto retornará una cadena detallando los atributos de la clase
        private string MostrarProducto(Producto p)
        {
            string retorno;
            retorno = this._marca + " " + this._precio + " " + this._codigoBarra;
            return retorno;
        }

        //Igualdad(Producto, Producto). Retornará true, sison del mismo tipo y suslas marcas y códigos
        //de barra son iguales, false, caso contrario.
        public static bool operator  == (Producto prodUno, Producto prodDos)
        {
            bool retorno = false;
            if(prodUno._marca == prodDos._marca && prodUno._precio == prodDos._precio && prodUno._codigoBarra == prodDos._codigoBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }


        //Igualdad(Producto, EMarcaProducto). Retornará true, si la marca del producto coincide con
        //el enumerado pasado por parámetro, false, caso contrario.
        public static bool operator == (Producto pordUno, EMarcaProducto marca)
        {
            bool retorno = false;
            if (pordUno.Marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto pordUno, EMarcaProducto marca)
        {
            return !(pordUno == marca);
        }

        //El método Equals deberá indicar si dos objetos son del mismo tipo. Realizarlo en 1 línea de código
        public override bool Equals(object obj)
        {
            return obj is Producto;
        }

        //CONVERSIONES
        //Explícito.Retornará el código de barra del producto que recibe como parámetro
        public static explicit operator int(Producto p)
        {
            return p._codigoBarra;
        }
        //Implícito.Retornará toda la información del producto, rehutilizando código.
        public static implicit operator string(Producto p)
        {
            return "MARCA: " + p.Marca.ToString() + "\nCODIGO DE BARRAS: " + ((int)p).ToString() + "\nPRECIO: " + p.Precio.ToString();
        }

        //METODOS
        //Contendrá un método virtual llamado Consumir que retornará el string "Parte de unamezcla."

        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }
    }
}
