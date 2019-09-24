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
    public partial class FrmCatedra : Form
    {
        Catedra miCatedra;
        List<AlumnoCalificado> misAlumnos;

        public FrmCatedra()
        {
            InitializeComponent();
            foreach (ETipoOrdenamiento orden in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrden.Items.Add(orden);
            }
            this.cmbOrden.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
            this.cmbOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            this.miCatedra = new Catedra();
            this.misAlumnos = new List<AlumnoCalificado>();
        }

        private void FrmCatedra_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno();

            alumno.ShowDialog();

            if (alumno.DialogResult == DialogResult.OK)
            {
                //for (int i = 0; i < this.miCatedra.Alumnos.Count; i++)
                //{
                //    if ( == alumno.MiAlumno.Legajo)
                //    {

                //    }
                //}
                if (!(this.miCatedra + alumno.MiAlumno))
                {
                    MessageBox.Show("No se pudo agregar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.ActualizarListadoAlumnos();

            }
        }
        private void ActualizarListadoAlumnos()
        {
            this.listBox1.Items.Clear();
            for (int i = 0; i < this.miCatedra.Alumnos.Count; i++)
            {
                this.listBox1.Items.Add(this.miCatedra.Alumnos[i]);
            }
            
        }
        private void btnCalificar_Click(object sender, EventArgs e)
        {

        }

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
