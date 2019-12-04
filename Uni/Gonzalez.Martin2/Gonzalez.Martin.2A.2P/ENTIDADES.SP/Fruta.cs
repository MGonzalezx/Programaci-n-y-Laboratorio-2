using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ENTIDADES.SP
{
    [XmlInclude(typeof(Manzana))]
    [XmlInclude(typeof(Durazno))]
    [XmlInclude(typeof(Banana))]

    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;

        public abstract bool TieneCarozo { get;  }

        public string MiColor { get {return this._color; } set { this._color = value; } }
        public double MiPeso { get { return this._peso; } set { this._peso = value; } }

        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            return "Color: " + this._color + "Peso: " + this._peso.ToString() + "\n";
        }
    }
}
