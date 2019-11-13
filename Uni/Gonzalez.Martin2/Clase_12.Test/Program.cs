using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12.Entidades;

namespace Clase_12.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Empleado miEmpleado = new Empleado("Juan", "Perez", 111);
            Program Manejador = new Program();
            miEmpleado.LimiteSueldo += new LimiteSueldoDelegado(Manejador.ManejadorLimiteSueldo);
            miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(Program.MenjadorLimiteSueldoMejorado);
            miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(Manejador.MenjadorLimiteSueldoMejorado2);
            miEmpleado.MiSueldo = 33000;

            Console.WriteLine(miEmpleado.ToString());

            Console.ReadLine();
        }

        public void ManejadorLimiteSueldo(double sueldo, Empleado emp)
        {
            Console.WriteLine("*********************************\n");
            Console.WriteLine("Empleado: \n" + emp.ToString() + "Sueldo que quiere ganar: " + sueldo.ToString() + "\n");
            Console.WriteLine("*********************************\n");

        }

        public static void MenjadorLimiteSueldoMejorado(Empleado emp, EmpleadoEventArgs e)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Empleado Mejorado: \n" + emp.ToString() + "Sueldo Asignado: " + e.SueldoAsignar);
            Console.WriteLine("*********************************\n");
        }

        public  void MenjadorLimiteSueldoMejorado2(Empleado emp, EmpleadoEventArgs e)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Empleado Mejorado: \n" + emp.ToString() + "Sueldo Asignado: " + e.SueldoAsignar);
            Console.WriteLine("*********************************\n");
        }
    }
}
