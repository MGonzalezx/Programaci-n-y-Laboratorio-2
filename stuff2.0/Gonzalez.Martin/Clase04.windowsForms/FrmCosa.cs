using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase04.entidades;

namespace Clase04.windowsForms
{
  public partial class FrmCosa : Form
  {
    public FrmCosa()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Cosa obj1 = new Cosa();
      //MessageBox.Show(obj1.Mostrar());
      //this.button1.Text = "Botoncito";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Cosa obj1 = new Cosa();
      MessageBox.Show(obj1.Mostrar());
      this.button1.Text = "Boton";
      this.button1.BackColor= Color.Magenta;
      this.button1.ForeColor = Color.Orange;
    }
  }
}
