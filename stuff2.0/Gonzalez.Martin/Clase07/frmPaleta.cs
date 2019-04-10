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
    private Paleta _miPaleta;

    public Paleta MiPaleta
    {
      get { return _miPaleta; }
      //set { _miPaleta = value; }
    }


    public frmPaleta()
    {
      InitializeComponent();
      this._miPaleta = 5;
    }

    private void BtnMas_Click(object sender, EventArgs e)
    {
      frmTempera obj1 = new frmTempera();
      obj1.ShowDialog();
      this._miPaleta += obj1.MiTempera;
      
    }

    private void frmPaleta_Load(object sender, EventArgs e)
    {

    }
  }
}
