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
  public partial class frmTempera : Form
  {
    private Tempera _miTempera;

    public Tempera MiTempera
    {
      get { return _miTempera; }
      //set { _miTempera = value; }
    }

    public frmTempera()
    {
      InitializeComponent();
      foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
      {
        comboColor.Items.Add(color);
      }
    }

    private void frmTempera_Load(object sender, EventArgs e)
    {
      
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

    private void BtnAceptar_Click(object sender, EventArgs e)
    {
      String marca = this.txtMarca.Text;
      ConsoleColor color = (ConsoleColor) this.comboColor.SelectedItem;
      sbyte cantidad = Convert.ToSByte(this.txtCantidad.Text);

      Tempera obj = new Tempera(marca, color, cantidad);
      //MessageBox.Show(Tempera.Mostrar(obj));

      this._miTempera = obj;
            this.DialogResult = DialogResult.OK;
    
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
            this.DialogResult = DialogResult.Cancel;
    }
  }
}
