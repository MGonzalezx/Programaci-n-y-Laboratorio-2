using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorismo.Entidades;

namespace CentralitaWindowsForms
{
    public partial class FrmCentralita : Form
    {
        Centralita miCentralita;
        Llamada miLlamada;
        List<Centralita> misLlamadas;
        public FrmCentralita()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //this.WindowState = FormWindowState.Maximized;
            this.cboOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboOrdenamiento.Items.Add("Duracion");
            this.cboOrdenamiento.Items.Add("Ascendente");
            this.cboOrdenamiento.Items.Add("Descendente");
            misLlamadas = new List<Centralita>();
            miCentralita = new Centralita();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLocal nuevoLocal = new frmLocal();

            nuevoLocal.ShowDialog();

            if (nuevoLocal.DialogResult == DialogResult.OK)
            {
                this.miCentralita += nuevoLocal.MiLlamada;

                this.ActualizarListadoLlamadas();
            }
        }

        private void ActualizarListadoLlamadas()
        {
            this.lstVisor.Items.Clear();
            for (int i = 0; i < this.miCentralita.Llamadas.Count; i++)
            {
                this.lstVisor.Items.Add(this.miCentralita.Llamadas[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProvincial nuevoProvincial = new frmProvincial();

            nuevoProvincial.ShowDialog();

            if (nuevoProvincial.DialogResult == DialogResult.OK)
            {
                this.miCentralita += nuevoProvincial.MiLlamada;

                this.ActualizarListadoLlamadas();
            }
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orden = (string)this.cboOrdenamiento.SelectedItem;

            switch(orden)
            {
                case "Duracion":
                    this.miCentralita.Llamadas.Sort(miLlamada.OrdenarPorDuracion);
                    break;
            }
        }
    }
}
