using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase21.Entidades;
using System.IO;

namespace Clase21.windowsForms
{
  public partial class Form1 : Form
  {


    public Form1()
    {
      InitializeComponent();
            foreach (tipoManejador manejador in Enum.GetValues(typeof(tipoManejador)))
            {
                this.comboBox1.Items.Add(manejador);
            }
        }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado empleado = new EmpleadoMejorado();
            empleado.limiteSueldo += new DelSueldo(LimiteSueldoEmpleado);
            empleado.limiteSueldo += new DelSueldo(GuardarLog);
            if (this.comboBox1.SelectedIndex > -1)
            {
                if ((tipoManejador)this.comboBox1.SelectedItem == tipoManejador.limiteSueldos)
                {
                    empleado.limiteSueldo -= new DelSueldo(GuardarLog);
                }
                else if ((tipoManejador)this.comboBox1.SelectedItem == tipoManejador.log)
                {
                    empleado.limiteSueldo -= new DelSueldo(LimiteSueldoEmpleado);
                }
                empleado.Nombre = this.txtNombre.Text;
                empleado.Legajo = Int32.Parse(this.txtLegajo.Text);
                empleado.Sueldo = float.Parse(this.txtSueldo.Text);
            }
            else
            {
                MessageBox.Show("No se a seleccionado ningun manejador");
            }
        }

        public static void LimiteSueldoEmpleado(EmpleadoMejorado e, EmpleadoSueldoArgs args)
        {
            MessageBox.Show("Al empleado\n" + e.Nombre + "\nSe le quizo asignar un sueldo de " + args.Sueldo.ToString());
        }

        public void GuardarLog(EmpleadoMejorado e, EmpleadoSueldoArgs args)
        {
            try
            {
                StreamWriter Archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\incidentes.log", true);
                Archivo.WriteLine(DateTime.Now.ToString() + " - " + e.Nombre + " - " + e.Legajo.ToString() + " - " + args.Sueldo);
                Archivo.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
