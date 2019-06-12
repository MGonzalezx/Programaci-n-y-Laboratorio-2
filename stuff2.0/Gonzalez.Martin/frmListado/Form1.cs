using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase19SQL;

namespace frmListado
{
  public partial class frmListado : Form
  {
    private List<Persona> _personas = new List<Persona>();
    private DataTable _tabla = new DataTable();
    
    public frmListado()
    {
      InitializeComponent();
    }

    private void frmListado_Load(object sender, EventArgs e)
    {
      AccesoDatos datos = new AccesoDatos();
      this._personas = datos.TraerTodos();
      this._tabla = datos.TraerTablaPersonas();
      this.dataGridView1.DataSource = this._tabla;
      
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

  }
}
