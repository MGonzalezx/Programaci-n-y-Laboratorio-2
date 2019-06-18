using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase20.WindowsForm2
{
  public partial class frmTest2 : Form
  {
    public frmTest2()
    {
      InitializeComponent();
      this.Load += new System.EventHandler(this.Inicializar);
    }

    public void Inicializar(object sender, EventArgs e)
    {
      this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
    }

    public void MiManejador(object sender, EventArgs e)
    {
      string s = ((Control)sender).Name;
      MessageBox.Show(s);

      if (s == "btnBoton1")
      {
        this.btnBoton1.Click -= new System.EventHandler(this.MiManejador);
        this.btnBoton2.Click += new System.EventHandler(this.MiManejador);
      }
      else if (s == "btnBoton2")
      {
        this.btnBoton2.Click -= new System.EventHandler(this.MiManejador);
        this.btnBoton3.Click += new System.EventHandler(this.MiManejador);
      }
      else if (s == "btnBoton3")
      {
        this.btnBoton3.Click -= new System.EventHandler(this.MiManejador);
        this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
      }
    }
    
  }

}

