using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Gonzalez.Practica
{
     public class Jugo : Producto
    {
        //Jugo posee un único atributo propio, que será inicializado por su único constructor de instancia.

        protected ESaborJugo _sabor;
        protected static bool DeConsumo;


        //CalcularCostoDeProducción será el 40% del precio final.
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (float)0.4 * this.Precio;
            }
        }

        //CONSTRUCTORES

        //El constructor de clase inicializará el atributo DeConsumo en verdadero.
        static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor) : base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        //Consumir retornará "Bebible".
        public override string Consumir()
        {
            return "Bebible";
        }

        //El método privado de instancia MostrarJugo, retornará una cadena conteniendo la
        //información completa del objeto.
        private string MostrarJugo()
        {
            return (string)this + "\nSABOR: " + this._sabor + "\n";
        }

        //El método ToString hará publicos los datos del producto.
        public override string ToString()
        {
            return this.MostrarJugo();
        }
    }
}
