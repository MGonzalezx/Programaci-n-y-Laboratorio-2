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
                //String prueba = (alumno.MiAlumno.Nombre + " " + alumno.MiAlumno.Apellido + " " + alumno.MiAlumno.Legajo.ToString() + " " + alumno.MiAlumno.Examen.ToString());

                //this.listBox1.Items.Add(prueba);
                //this.listBox1.Items.Add(alumno.MiAlumno);
                //this.listBox1.DisplayMember(alumno.MiAlumno);

                    this.miCatedra += alumno.MiAlumno;
                
                    for (int i = 0; i < this.miCatedra.Alumnos.Count; i++)
                    {
                        if (this.miCatedra.Alumnos[i] != null)
                        {
                            this.listBox1.Items.Add(this.miCatedra.Alumnos[i]);
                        }

                    }
                
 
            }
        }
    }
}
