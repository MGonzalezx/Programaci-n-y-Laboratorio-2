using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPersonas
{
    public partial class frmVisorDataTable : frmVisorPersona
    {
        private DataTable dataTable;

        public DataTable MiDataTable { get { return this.dataTable; } }

        public frmVisorDataTable(DataTable dataTable) : base()
        {
            InitializeComponent();

            this.dataTable = dataTable;
            this.ActualizarListadoPersonasData();
        }


        public void ActualizarListadoPersonasData()
        {
            try
            {
                this.lstVisor.Items.Clear();
                
                foreach(DataRow fila in this.dataTable.Rows)
                {
                    if (fila.RowState != DataRowState.Deleted)
                    {
                        this.lstVisor.Items.Add(fila[1].ToString()
                      + " - " + fila[2].ToString() + " - " + fila[3].ToString());
                    }
                }
                //for (int i = 0; i < this.dataTable.Rows.Count; i++)
                //{
                //    if(this.dataTable.Rows[i].RowState != DataRowState.Deleted)
                //    {
                //        this.lstVisor.Items.Add(this.dataTable.Rows[i][0].ToString() + " - " + this.dataTable.Rows[i][1].ToString()
                //      + " - " + this.dataTable.Rows[i][2].ToString() + " - " + this.dataTable.Rows[i][3].ToString());
                //    }
                    
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            DataRow mifila;
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    mifila = this.dataTable.NewRow();
                    mifila[1] = frm.Persona.nombre;
                    mifila[2] = frm.Persona.apellido;
                    mifila[3] = frm.Persona.edad;

                    this.dataTable.Rows.Add(mifila);

                    this.ActualizarListadoPersonasData();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstVisor.SelectedIndex;
            if (index != -1)
            {


                DataRow fila = this.dataTable.Rows[index];
                frmPersona frm = new frmPersona(new Entidades.Persona(fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[3])));
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        fila[1] = frm.Persona.nombre;
                        fila[2] = frm.Persona.apellido;
                        fila[3] = frm.Persona.edad;
                        this.ActualizarListadoPersonasData();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {

            int index = this.lstVisor.SelectedIndex;
            if(index != -1 )
            {

            DataRow fila = this.dataTable.Rows[index];
            fila.Delete();            
            this.ActualizarListadoPersonasData();
            }
        }
    }
}
