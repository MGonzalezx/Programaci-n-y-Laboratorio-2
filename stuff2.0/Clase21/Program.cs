using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;
using Entidades.Externa.Sellada;


namespace Clase21
{
  class Program
  {
    static void Main(string[] args)
    {
            Persona persona = new Persona("Juan", "Perez", 20, Entidades.Alumnos.ESexo.Masculino);
            PersonaExternaSellada personaDos = new PersonaExternaSellada("Juan", "Perez", 20, Entidades.Externa.Sellada.ESexo.Masculino);
            Console.WriteLine(Extensora.Extensora.Mostrar(personaDos));
            Console.ReadKey();

        }
  }
}
