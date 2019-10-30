using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        public List<Persona> miListaPersonas;
        public frmVisorPersona()
        {
            InitializeComponent();
            miListaPersonas = new List<Persona>();

        }

        public frmVisorPersona (List<Persona> personaAux) : this()
        {
            this.miListaPersonas = personaAux;
            this.ActualizarListadoPersonas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.miListaPersonas.Add(frm.Persona);
                this.ActualizarListadoPersonas();
            }

        }

        public void ActualizarListadoPersonas()
        {
            this.lstVisor.Items.Clear();
            for (int i = 0; i < this.miListaPersonas.Count; i++)
            {
                this.lstVisor.Items.Add(this.miListaPersonas[i].ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(/*params*/);
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }
    }
}
