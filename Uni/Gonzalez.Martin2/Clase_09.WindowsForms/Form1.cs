using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clase_09.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtTexto.AutoSize = false;
            this.txtTexto.Size =new Size(250, 250);
            foreach (Environment.SpecialFolder folder in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                this.cmbUbicacion.Items.Add(folder);
            }
            this.cmbUbicacion.SelectedItem = Environment.SpecialFolder.Desktop;
            this.cmbUbicacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.SpecialFolder ubicacion = (Environment.SpecialFolder)this.cmbUbicacion.SelectedItem;
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(ubicacion) + @"\" + this.txtNombreArchivo.Text, true);
            writer.WriteLine(this.txtTexto.Text);
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.SpecialFolder ubicacion = (Environment.SpecialFolder)this.cmbUbicacion.SelectedItem;
            StreamReader reader = new StreamReader(Environment.GetFolderPath(ubicacion) + @"\" + this.txtNombreArchivo.Text);
            string contenido;
            //contenido = reader.ReadToEnd();
            while ((contenido = reader.ReadToEnd()) != null)
            {
                MessageBox.Show(contenido.ToString());
                break;
            }
            reader.Close();
           
        }
    }
}
