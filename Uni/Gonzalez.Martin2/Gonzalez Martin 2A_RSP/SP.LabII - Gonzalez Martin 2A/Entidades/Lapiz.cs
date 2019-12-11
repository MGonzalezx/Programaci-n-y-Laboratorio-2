using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : Utiles
    {
        

        public ConsoleColor color;
        public ETipoTrazo trazo;

        public Lapiz() : this(ConsoleColor.Black,ETipoTrazo.Fino, "vacio", 0)
        {

        }

        public Lapiz( ConsoleColor color, ETipoTrazo trazo, string marca, double precio) : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public override bool PreciosCuidados => true;

        public override string ToString()
        {
            return base.ToString() + " Color: " +this.color + " Trazo: "+ this.trazo;
        }
    }
}
