using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06.entidades;


namespace Clase07
{
  public partial class frmPaleta : Form
  {

        private Paleta _paleta;
        public frmPaleta()
    {
      InitializeComponent();
            this._paleta = 5;
    }

    private void BtnMas_Click(object sender, EventArgs e)
    {
      frmTempera obj1 = new frmTempera();
      obj1.ShowDialog();
            if(obj1.DialogResult == DialogResult.OK)
            {
                this._paleta += obj1.MiTempera;
                this.LstLista.Items.Clear();
                this.LstLista.Items.Add((string)this._paleta);
                
            }
      
    }

    private void frmPaleta_Load(object sender, EventArgs e)
    {

    }

        private void LstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
