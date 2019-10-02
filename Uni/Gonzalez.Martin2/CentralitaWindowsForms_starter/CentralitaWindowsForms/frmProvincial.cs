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
    public partial class frmProvincial : frmLlamada
    {
        //Provincial miProvincial;

        //public Provincial MiProvincial { get { return this.miProvincial; } }
        public frmProvincial()
        {
            InitializeComponent();
            foreach (EFranja examen in Enum.GetValues(typeof(EFranja)))
            {
                this.cmbFranja.Items.Add(examen);
            }
            this.cmbFranja.SelectedItem = EFranja.Franja_01;
            this.cmbFranja.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            EFranja tipoFranja = (EFranja)this.cmbFranja.SelectedItem;
            float duracion = float.Parse(this.txtDuracion.Text);
            base.miLlamada = new Provincial(this.txtNroOrigen.Text, tipoFranja, duracion, this.txtNroDestino.Text);

            base.btnAceptar_Click(sender, e);
        }
    }
}
