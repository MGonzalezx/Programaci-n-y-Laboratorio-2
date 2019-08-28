using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;

namespace Clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEntero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cosa objeto = new Cosa(this.txtCadena.Text,DateTime.Parse(this.txtFecha.Text),int.Parse(this.txtEntero.Text));
            lstLista.Items.Add(objeto.Monstrar());
            MessageBox.Show(objeto.Monstrar());
        }
    }
}
