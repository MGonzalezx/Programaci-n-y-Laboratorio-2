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
using System.Data.SqlClient;
using Entidades;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        public List<Persona> miListaPersonas;
        SqlCommand comando;
        SqlConnection connection;
        public frmVisorPersona()
        {
            InitializeComponent();
            miListaPersonas = new List<Persona>();

        }

        public frmVisorPersona(List<Persona> personaAux) : this()
        {
            this.miListaPersonas = personaAux;
            this.ActualizarListadoPersonas();
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.miListaPersonas.Add(frm.Persona);
                try
                {
                    connection = new SqlConnection(Properties.Settings.Default.Conexion);
                    this.connection.Open();
                    this.comando = new SqlCommand();
                    this.comando.Connection = connection;
                    this.comando.CommandType = CommandType.Text; this.comando.CommandText = "INSERT INTO[personas_bd].[dbo].[personas]" +
                        "([nombre] ,[apellido] ,[edad])" + "values" + "('" + frm.Persona.nombre + "'," + "'" + frm.Persona.apellido + "'," +
                        "'" + frm.Persona.edad + "')";
                    this.comando.ExecuteNonQuery();
                    this.connection.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

                this.ActualizarListadoPersonas();
            }

        }

        public void ActualizarListadoPersonas()
        {
            this.lstVisor.Items.Clear();
            for (int i = 0; i < this.miListaPersonas.Count; i++)
            {
                this.lstVisor.Items.Add(this.miListaPersonas[i].ToString());
            }

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(this.miListaPersonas[this.lstVisor.SelectedIndex]);
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.miListaPersonas[this.lstVisor.SelectedIndex] = frm.Persona;
                try
                {
                    connection = new SqlConnection(Properties.Settings.Default.Conexion);
                    this.connection.Open();
                    this.comando = new SqlCommand();
                    this.comando.Connection = connection;
                    this.comando.CommandType = CommandType.Text;
                    this.comando.CommandText = "UPDATE [personas_bd].[dbo].[personas]" +
                        "SET" + "[nombre] =" + "'" + frm.Persona.nombre + "'," + "[apellido] =" + "'" + frm.Persona.apellido + "'," +
                         "[edad]=" + "'" + frm.Persona.edad + "'" + "WHERE" + "[ID]=" + "'" + this.lstVisor.SelectedIndex + "'";
                    this.comando.ExecuteNonQuery();
                    this.connection.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

                this.ActualizarListadoPersonas();
            }
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(this.miListaPersonas[this.lstVisor.SelectedIndex]);
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.miListaPersonas.Remove(this.miListaPersonas[this.lstVisor.SelectedIndex]);
                try
                {
                    connection = new SqlConnection(Properties.Settings.Default.Conexion);
                    this.connection.Open();
                    this.comando = new SqlCommand();
                    this.comando.Connection = connection;
                    this.comando.CommandType = CommandType.Text;
                    this.comando.CommandText = "DELETE FROM [personas_bd].[dbo].[personas]" +
                         "WHERE" + "[id]=" + "'" + this.lstVisor.SelectedIndex + "'";
                    this.comando.ExecuteNonQuery();
                    this.connection.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
                this.ActualizarListadoPersonas();
            }
        }
    }
}
