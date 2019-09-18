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
        List<AlumnoCalificado> miAlumno;

        public FrmCatedra()
        {
            InitializeComponent();
        }

        private void FrmCatedra_Load(object sender, EventArgs e)
        {

        }
    }
}
