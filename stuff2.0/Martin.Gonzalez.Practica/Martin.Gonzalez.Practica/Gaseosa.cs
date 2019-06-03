using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Gonzalez.Practica
{
    public class Gaseosa : Producto
    {
        protected float _litros;
        protected static bool DeConsumo;

        //PROPIEDAD
        //CalcularCostoDeProducción será el 42% del precio final.
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (float)0.42 * this.Precio;
            }
        }

        //CONSTRUCTORES

        //Gaseosa posee un único atributo propio, que será inicializado sólo por una de las sobrecargas
        //del constructor(reutilizar código).


        //El constructor de clase inicializará el atributo DeConsumo en verdadero.
        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros) : base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros) : this((int)p, p.Precio, p.Marca, litros)
        {


        }

        //METODOS
        //Consumir retornará "Bebible".
        public override string Consumir()
        {
            return "Bebible";
        }

        //El método privado de instancia MostrarGaseosa, retornará una cadena conteniendo la información completa del objeto.
        private string MostrarGaseosa()
        {
            return (string)this + "\nLITROS: " + this._litros + "\n";
        }


        //El método ToString hará publicos los datos del producto
        public override string ToString()
        {
            return this.MostrarGaseosa();
        }
    }
}
