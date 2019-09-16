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
                //this.miPaleta[0] = tempera.MiTempera;
                
                this.miPaleta += tempera.MiTempera;
                

                for (int i = 0; i < this.miPaleta.CantidadMaximaColores; i++)
                {
                    if(this.miPaleta[i] != null)
                    {
                        this.listBox1.Items.Add((string)(this.miPaleta[i]));
                    }
                    
                }
               
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //llamo al metodo anterior que ya sabe que hacer
            this.crearTemperaToolStripMenuItem_Click(sender, e);

            //frmTempera tempera = new frmTempera();
            ////this.listBox1.Items.Clear();

            //tempera.ShowDialog();
            //if (tempera.DialogResult == DialogResult.OK)
            //{
            //    this.miPaleta += tempera.MiTempera;

            //    this.listBox1.Items.Add((string)this.miPaleta);
            //}
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            frmTempera tempera = new frmTempera();
            //this.listBox1.Items.Clear();

            tempera.ShowDialog();
            if (tempera.DialogResult == DialogResult.OK)
            {
                this.miPaleta -= tempera.MiTempera;


                for(int i = 0; i < this.miPaleta.CantidadMaximaColores; i++)
                {
                    if (this.miPaleta[i] != null)
                    {
                        this.listBox1.Items.Add((string)this.miPaleta[i]);
                    }

                }
            }

            //this.listBox1.Items.Remove(this.listBox1.SelectedItem);
        }


        //SELECCIONAR DEL LISTADO
        //CLICK EN MODIFICAR
        //MOSTRAR FRM TEMPERA(CON DATOS DE LA TEMPERA)
        //MODIFICAR LA TEMPERA
        //REEMPLAZAR LA TEMPERA
        //REFRESCAR LISTADO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmTempera tempera = new frmTempera(this.miPaleta[this.listBox1.SelectedIndex]);
            
            tempera.ShowDialog();
            if (tempera.DialogResult == DialogResult.OK)
            {
                this.listBox1.Items.Clear();
                this.miPaleta[this.listBox1.SelectedIndex] = tempera.MiTempera;
                this.listBox1.Items.Insert(this.listBox1.SelectedIndex, (string)this.miPaleta);
            }
            
            
        }
    }
}
