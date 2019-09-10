using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_06.WindowsForms
{
    public partial class frmTempera : Form
    {
        Tempera miTempera;

        public Tempera MiTempera { get {return this.miTempera; }  }

        public frmTempera()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            //getvalue me devuelve el objeto enumerado del tipo que corresponda
            // todo de tipo ConsoleColor para eso usamos typeof
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbColor.Items.Add(color);
            }
            //POR DEFECTO VA A APARECER EL COLOR MAGENTA EN EL COMBOBOX
            this.cmbColor.SelectedItem = ConsoleColor.Magenta;
            //PARA QUE EL USUARIO NO PUEDA ESCRIBIR EN EL COMBOBOX
            this.cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {

        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConsoleColor color = (ConsoleColor)this.cmbColor.SelectedItem;

            this.miTempera = new Tempera(color, this.txtMarca.Text, 
                int.Parse(this.txtCantidad.Text));
            this.DialogResult = DialogResult.OK;

            //MessageBox.Show(miTempera);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
