using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase21.Entidades;

namespace Clase21.windowsForms
{
  public partial class Form1 : Form
  {


    public Form1()
    {
      InitializeComponent();
      foreach( tipoManejador item in  )
      {
        comboBox1.Items.Add(item);
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
