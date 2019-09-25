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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        AlumnoCalificado miAlumnoCalificado;

        public AlumnoCalificado MiAlumnoCalificado { get { return this.miAlumnoCalificado; } }

        public FrmAlumnoCalificado(Alumno alumno) : base(alumno)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            base.txtApellido.Enabled = false;
            base.txtNombre.Enabled = false;
            base.txtLegajo.Enabled = false;
            base.cmbTipoExamen.Enabled = false;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e) 
        {
            ETipoExamen examen = (ETipoExamen)this.cmbTipoExamen.SelectedItem;

            this.miAlumnoCalificado = new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text,
                int.Parse(this.txtLegajo.Text), examen, int.Parse(this.txtNota.Text));


            
            this.DialogResult = DialogResult.OK;
        }

        //public FrmAlumnoCalificado() : this()
        //{
        //    base.txtApellido.Enabled = false;
        //    base.txtNombre.Enabled = false;
        //    base.txtLegajo.Enabled = false;
        //    base.cmbTipoExamen.Enabled = false;
        //}



    }
}
