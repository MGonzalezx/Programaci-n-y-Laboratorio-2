using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_08.Entidades;

namespace Clase_08.WindowsForms
{
    public partial class FrmAlumno : Form
    {
        Alumno miAlumno;

        public Alumno MiAlumno { get { return this.miAlumno; }  }

        public FrmAlumno()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (ETipoExamen examen in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(examen);
            }
            this.cmbTipoExamen.SelectedItem = ETipoExamen.Final;
            this.cmbTipoExamen.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public FrmAlumno(Alumno a) : this()
        {
            this.txtNombre.Text = a.Nombre;
            this.txtApellido.Text = a.Apellido;
            this.txtLegajo.Text = a.Legajo.ToString();
            this.cmbTipoExamen.Text = a.Examen.ToString();
            this.txtLegajo.Enabled = false;
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ETipoExamen examen = (ETipoExamen)this.cmbTipoExamen.SelectedItem;

            this.miAlumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text,
                int.Parse(this.txtLegajo.Text), examen);


            //if (int.Parse(this.txtLegajo.Text) == this.miAlumno.Legajo)
            //{
            //    MessageBox.Show("Legajo ya ingresado", "ERROR",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
