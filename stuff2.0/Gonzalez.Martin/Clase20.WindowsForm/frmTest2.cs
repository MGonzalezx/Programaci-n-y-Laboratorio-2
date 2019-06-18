using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase20.WindowsForm
{
  public partial class frmTest2 : Form
  {
    public frmTest2()
    {
      InitializeComponent();
      //this.Load += new System.EventHandler(Inicializar);

    }

    private void frmTest2_Load(object sender, EventArgs e)
    {
      this.btnBoton1.Click += new System.EventHandler(MiManejador);
    }

    public static void MiManejador(object sender, EventArgs e)
    {
      MessageBox.Show("Boton 1");
    }

  }
}
