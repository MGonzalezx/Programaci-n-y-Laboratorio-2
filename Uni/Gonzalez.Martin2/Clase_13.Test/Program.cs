using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_13.MisEntidades;
// Una dll que no hicimos nosotros. Pero que tiene adentro?
// click derecho en la dll (referencias) y examinar
using Entidades.Externa;
//Para la sellada necesitamos un metodo de extensión
//Un metodo de extensión tiene que estar en una clase estática
using Entidades.Externa.Sellada;


namespace Clase_13.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Son variables protected, para poder mostrarlas:
            //#1 Tienen que tener una Prop (S/L)
            //#2 Metodo de tipo Getters (-> prop S/L)
            Persona miPersona = new Persona("Juan", "Perez", 11111111);

            PersonitaExterna miPersonitaExterna = new PersonitaExterna("Ramiro", "Jaurez", 50, Entidades.Externa.ESexo.Masculino);

           PersonaExternaSellada miPersonaExternaSellada = new PersonaExternaSellada("Fede", "Rico", 25, Entidades.Externa.Sellada.ESexo.Indefinido);

            List<Persona> miLista = miPersona.ObtenerListadoBD();

            //Si queremos mostrar esta informacion muchas veces, lo ponemos en un metodo.
            //# ObtenerInfo() : string

            //Console.WriteLine(miPersona.ObtenerInfo());
            //Console.WriteLine(miPersonitaExterna.ObtenerInfo());
            //Console.WriteLine(miPersonaExternaSellada.ObtenerInfo());
            //Console.WriteLine(miPersonaExternaSellada.EsNulo());

            foreach(Persona personita in miLista)
            {
                Console.WriteLine(personita.ObtenerInfoBD());
            }
            

            Console.ReadLine();

        }
    }
}
