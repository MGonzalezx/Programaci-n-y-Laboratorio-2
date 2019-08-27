using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_16
{
    class Alumno
    {   //VARIABLES
        public string nombre;
        public string apellido;
        public int legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        //METODOS
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public void CalcularFinal()
        {
            
            if (nota1 >= 4 && nota2 >= 4 )
            {
                Random auxiliar = new Random();
                float nota = auxiliar.Next(1, 10);

                this.notaFinal = nota;
                
            }else
            {  
                this.notaFinal = -1;
                
            }
            

        }

        public string Mostrar()
        {
            if(this.notaFinal == -1)
            {
                return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Legajo: " +
                this.legajo.ToString() + "\n - Nota1: " + this.nota1.ToString() + " - Nota2: " +
                this.nota2.ToString() + " - Nota Final: Alumno desaprobado" + "\n";
            }else
            {
                return "Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Legajo: " +
                this.legajo.ToString() + "\n - Nota1: " + this.nota1.ToString() + " - Nota2: " +
                this.nota2.ToString() + " - Nota Final: " + this.notaFinal.ToString() + "\n";
            }
            
        }
    }
}
