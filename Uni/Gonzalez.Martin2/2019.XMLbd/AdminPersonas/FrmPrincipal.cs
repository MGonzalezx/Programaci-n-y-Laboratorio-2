using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;
using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        //Para conectarnos al SQL
        SqlConnection connection;
        SqlCommand comando;
        SqlDataReader lector;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            this.openFileDialog1.ShowDialog();
            List<Persona> miListaPersonaSola = new List<Persona>();
            try
            {
                XmlSerializer desSerializador = new XmlSerializer(typeof(List<Persona>));

                //un objeto que lo lea
                XmlTextReader lector = new XmlTextReader(this.openFileDialog1.FileName);

                //Lo mostramos
                miListaPersonaSola = (List<Persona>)desSerializador.Deserialize(lector);
                this.lista = miListaPersonaSola;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            this.saveFileDialog1.ShowDialog();
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));

                //Ahora necesitamos un objeto que sepa escribirlo en un archivo fisico
                XmlTextWriter escritor = new XmlTextWriter(this.saveFileDialog1.FileName, Encoding.UTF8);

                //Con esta linea serializamos en el path deseado, al objeto
                serializador.Serialize(escritor, lista);
                escritor.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();
            this.lista = frm.miListaPersonas;

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Nos conectamos al SQL
            connection = new SqlConnection(Properties.Settings.Default.Conexion);
            try
            {
                connection.Open();
                MessageBox.Show("Exito");
                this.comando = new SqlCommand();
                this.comando.Connection = connection;
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT TOP 1000[id] ,[nombre] ,[apellido] ,[edad] FROM[personas_bd].[dbo].[personas]";
                this.lector = comando.ExecuteReader();
                while (lector.Read() != false)
                {
                    MessageBox.Show((string)lector[0] (string)lector[1] (string)lector[2] (int)lector[3]);
                }
                connection.Close();
            }
            catch( Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }
    }
}
