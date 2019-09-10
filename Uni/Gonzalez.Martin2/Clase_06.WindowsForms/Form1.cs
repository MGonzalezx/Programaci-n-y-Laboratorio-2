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
    public partial class Form1 : Form
    {
        Paleta miPaleta;

        public Form1()
        {
            //VA A SER CONTENEDOR
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.groupBox1.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miPaleta = 5;
            this.groupBox1.Visible = true;
            this.crearPaletaToolStripMenuItem.Enabled = false;
        }

        private void crearTemperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera tempera = new frmTempera();

            //PONEMOS CUAL ES SU CONTENEDOR PADRE.
            //tempera.MdiParent = this;

            tempera.ShowDialog();
            if(tempera.DialogResult == DialogResult.OK)
            {
                this.miPaleta += tempera.MiTempera;

                this.listBox1.Items.Add(this.miPaleta);
            }
            
        }
    }
}
