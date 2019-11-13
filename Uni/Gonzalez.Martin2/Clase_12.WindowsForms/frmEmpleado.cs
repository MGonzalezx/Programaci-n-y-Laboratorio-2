using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_12.Entidades;
using Clase_12.Test;

namespace Clase_12.WindowsForms
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
            this.cmbManejador.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (TipoManejador manejador in Enum.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(manejador);
            }
            this.cmbManejador.SelectedItem = TipoManejador.LimiteSueldo;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {

                int legajo = Convert.ToInt32(this.txtLegajo.Text);
                Empleado miEmpleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text, legajo);

                
                switch ((TipoManejador)this.cmbManejador.SelectedIndex)
                {
                    case TipoManejador.LimiteSueldo:

                        miEmpleado.LimiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);

                        break;

                    case TipoManejador.LimiteSueldoMejorado:

                        miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(frmEmpleado.MenjadorLimiteSueldoMejorado);
                        miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(this.MenjadorLimiteSueldoMejorado2);

                        break;

                    case TipoManejador.Todos:

                        miEmpleado.LimiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);
                        miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(frmEmpleado.MenjadorLimiteSueldoMejorado);
                        miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(this.MenjadorLimiteSueldoMejorado2);

                        break;

                    default:
                        break;
                }

                //if ((TipoManejador)this.cmbManejador.SelectedIndex == TipoManejador.LimiteSueldo)
                //{
                //    miEmpleado.LimiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);
                //}
                //else if ((TipoManejador)this.cmbManejador.SelectedIndex == TipoManejador.LimiteSueldoMejorado)
                //{
                //    miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(frmEmpleado.MenjadorLimiteSueldoMejorado);
                //    miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(this.MenjadorLimiteSueldoMejorado2);
                //}
                //else if ((TipoManejador)this.cmbManejador.SelectedIndex == TipoManejador.Todos)
                //{
                //    miEmpleado.LimiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);
                //    miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(frmEmpleado.MenjadorLimiteSueldoMejorado);
                //    miEmpleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(this.MenjadorLimiteSueldoMejorado2);
                //}

                int sueldo = Convert.ToInt32(this.txtSueldo.Text);
                miEmpleado.MiSueldo = sueldo;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }

        public void ManejadorLimiteSueldo(double sueldo, Empleado emp)
        {

            MessageBox.Show("Empleado: \n" + emp.ToString() + "Sueldo que quiere ganar: " + sueldo.ToString() + "\n");

        }

        public static void MenjadorLimiteSueldoMejorado(Empleado emp, EmpleadoEventArgs e)
        {

            MessageBox.Show("Empleado Mejorado: \n" + emp.ToString() + "Sueldo que quiere ganar: " + e.SueldoAsignar);

        }

        public void MenjadorLimiteSueldoMejorado2(Empleado emp, EmpleadoEventArgs e)
        {

            MessageBox.Show("Empleado Mejorado2: \n" + emp.ToString() + "Sueldo que quiere ganar: " + e.SueldoAsignar);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtLegajo.Clear();
            this.txtSueldo.Clear();
        }
    }
}
