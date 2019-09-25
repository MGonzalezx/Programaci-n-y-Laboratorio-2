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

        private void ActualizarListadoAlumnosCalificados()
        {
            this.listBox2.Items.Clear();
            for (int i = 0; i < this.misAlumnos.Count; i++)
            {
                this.listBox2.Items.Add(this.misAlumnos[i]);
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            FrmAlumnoCalificado alumnoCalificado = new FrmAlumnoCalificado(this.miCatedra.Alumnos[this.listBox1.SelectedIndex]);

            alumnoCalificado.ShowDialog();


            if (alumnoCalificado.DialogResult == DialogResult.OK)
            {
                this.misAlumnos.Add(alumnoCalificado.MiAlumnoCalificado);
               

                if (!(this.miCatedra - this.miCatedra.Alumnos[this.listBox1.SelectedIndex]))
                {
                    MessageBox.Show("No se pudo agregar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.ActualizarListadoAlumnosCalificados();

                 this.ActualizarListadoAlumnos();

            }
        }

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ETipoOrdenamiento orden = (ETipoOrdenamiento)this.cmbOrden.SelectedItem;

            //switch (orden)
            //{
            //    case ETipoOrdenamiento.ApellidoAscendente:

            //        Alumno.OrdenarPorApellidoAsc(,);
            //        this.ActualizarListadoAlumnos();
            //        break;
            //    case ETipoOrdenamiento.ApellidoDescendente:
            //        Alumno.OrdenarPorApellidoDesc(,);
            //        this.ActualizarListadoAlumnos();
            //        break;
            //    case ETipoOrdenamiento.LegajoAscendente:
            //        Alumno.OrdenarPorLegajoAsc(,);
            //        this.ActualizarListadoAlumnos();
            //        break;
            //    case ETipoOrdenamiento.LegajoDescendente:
            //        Alumno.OrdenarPorLegajoDesc(,);
            //        this.ActualizarListadoAlumnos();
            //        break;
            //}

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno(this.miCatedra.Alumnos[this.listBox1.SelectedIndex]);

            alumno.ShowDialog();
      
            if (alumno.DialogResult == DialogResult.OK)
            {
                //this.listBox1.Items.Clear();
                this.miCatedra.Alumnos[this.listBox1.SelectedIndex] = alumno.MiAlumno;
                this.listBox1.Items.Insert(this.listBox1.SelectedIndex, this.miCatedra.Alumnos);
                this.ActualizarListadoAlumnos();
                
            }
        }
    }
}
