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
    public partial class frmLocal : frmLlamada
    {
        //Local miLocal;
        //public Local MiLocal { get { return this.miLocal; } }
        public frmLocal()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float duracion = float.Parse(this.txtDuracion.Text);
            float costo = float.Parse(this.txtCosto.Text);
            base.miLlamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, costo);
            
            base.btnAceptar_Click(sender, e);
        }
    }
}
