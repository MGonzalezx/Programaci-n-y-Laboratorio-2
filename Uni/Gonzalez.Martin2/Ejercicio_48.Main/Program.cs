using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48;

namespace Ejercicio_48.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(10);
            Recibo r1 = new Recibo();
            Recibo r2 = new Recibo(11);
            Documento d1 = new Documento(120);
            Contabilidad<d1, f1> cont = new Contabilidad<d1, f1>(); 
        }
    }
}
