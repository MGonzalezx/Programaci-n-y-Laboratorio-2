using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        { /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
           calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
           con DateTime.Now) */

            Console.Title = "Ejercicio Nro 7";

            DateTime fechaDeNacimiento;
            DateTime fechaDeHoy = DateTime.Now;
            TimeSpan dias;
            int diasVividos;

            Console.Write("Ingrese fecha de nacimiento(dia/mes/año): ");
            fechaDeNacimiento = DateTime.Parse(Console.ReadLine());

            dias = fechaDeHoy - fechaDeNacimiento;

            diasVividos = dias.Days;

            Console.Write("Dias vividos: {0}", diasVividos);
            
            Console.ReadLine();
        }
    }
}
