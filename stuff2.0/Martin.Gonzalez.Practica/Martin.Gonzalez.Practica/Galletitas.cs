using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Gonzalez.Practica
{
    public class Galletitas : Producto
    {

        //Galletita posee un único atributo propio, que será inicializado por su único constructor
        protected float _peso;
        protected static bool DeConsumo;


        //CalcularCostoDeProducción será el 33% del precio final.
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (float)0.33 * this.Precio;
            }
        }

        //CONSTRUCTORES

        //El constructor de clase inicializará el atributo DeConsumo en verdadero.
        static Galletitas()
        {
            Galletitas.DeConsumo = true;
        }

        public Galletitas(int codigoBarra, float precio, EMarcaProducto marca, float peso) : base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }

        //Consumir retornará "Comestible"
        public override string Consumir()
        {
            return "Comestible";
        }

        //El método privado de clase MostrarGalletita, retornará una cadena conteniendo la
        //información completa del objeto recibido por parámetro.
        private static string MostrarGalletita(Galletitas g)
        {
            return (string)g + "\nPESO: " + g._peso + "\n";
        }

        //El método ToString hará publicos los datos del producto.
        public override string ToString()
        {
            return MostrarGalletita(this);
        }
    }
}
