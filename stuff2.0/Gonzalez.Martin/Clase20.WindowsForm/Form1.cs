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
  public partial class frmTest : Form
  {
    public frmTest()
    {
      InitializeComponent();
      this.lblEtiqueta.Click += new System.EventHandler(Manejadora.Manejador);
      this.txtCuadroTexto.Click += new System.EventHandler(Manejadora.Manejador);
      this.btnBoton.Click += new System.EventHandler(Manejadora.Manejador);
      this.lblEtiqueta.Click += new System.EventHandler(Manejadora.Manejador);
      this.txtCuadroTexto.Click += new System.EventHandler(Manejadora.Manejador);
      this.btnBoton.Click += new System.EventHandler(Manejadora.Manejador);
    }

    private void MostrarMensaje(object sender, EventArgs e)
    {
      //MessageBox.Show("Evento click del botón");
      //habilita para que pueda ocurrir el evento en el label.
      //Si apreto dos o màs veces el boton, el texto del label se va a mostrar esa cantidad de veces
      //Ocurre esto this.lblEtiqueta.click += new EventHandler(lblEtiqueta_click);
      this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);
      //Agrega manejadores dinamicos a eventos por medio de otro.
      this.txtCuadroTexto.Click += new System.EventHandler(this.txtCuadroTexto_Click);
    }

    private void lblEtiqueta_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("Click desde el label");
      this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);

    }

    
    private void txtCuadroTexto_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void txtCuadroTexto_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("Click desde el texto");
    }

    private void frmTest_Load(object sender, EventArgs e)
    {

    }
  }
}
