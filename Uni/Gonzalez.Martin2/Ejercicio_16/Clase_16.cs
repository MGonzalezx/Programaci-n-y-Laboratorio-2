using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Clase_16
    {
        static void Main(string[] args)
        {
            Alumno miAlumno = new Alumno();
            miAlumno.nombre = "Ant";
            miAlumno.apellido = "Dant";
            miAlumno.legajo = 1;
            miAlumno.Estudiar(5, 5);

            Alumno miAlumno2 = new Alumno();
            miAlumno2.nombre = "Xaria";
            miAlumno2.apellido = "Rumanov";
            miAlumno2.legajo = 2;
            miAlumno2.Estudiar(6, 10);

            Alumno miAlumno3 = new Alumno();
            miAlumno3.nombre = "Sop";
            miAlumno3.apellido = "Dogger";
            miAlumno3.legajo = 3;
            miAlumno3.Estudiar(3, 2);

            Console.WriteLine(miAlumno.Mostrar());
            Console.WriteLine(miAlumno2.Mostrar());
            Console.WriteLine(miAlumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
