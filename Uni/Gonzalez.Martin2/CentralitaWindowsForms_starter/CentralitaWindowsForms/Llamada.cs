using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorismo.Entidades;

namespace CentralitaWindowsForms
{
    public partial class frmLlamada : Form
    {
        protected Llamada miLlamada;

        public Llamada MiLlamada { get { return this.miLlamada; } }
        public frmLlamada()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
