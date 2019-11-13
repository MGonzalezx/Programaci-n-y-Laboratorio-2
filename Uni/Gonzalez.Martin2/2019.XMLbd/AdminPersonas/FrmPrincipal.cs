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
using System.Threading;
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
        DataTable tablaPersonas;
        SqlDataAdapter adapter;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.tablaPersonas = new DataTable("Personas");
            this.CargarDataTable();
            this.comando = new SqlCommand();
            this.comando.Connection = connection;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "select * from personas";
            this.adapter = new SqlDataAdapter(comando.CommandText, connection);
            adapter.Fill(tablaPersonas);
            adapter.InsertCommand = new SqlCommand("INSERT INTO [personas_bd].[dbo].[personas] values (@p1, @p2, @p3)", connection);
            adapter.UpdateCommand = new SqlCommand("UPDATE [personas_bd].[dbo].[personas] set [nombre] = @p1, [apellido] = @p2, [edad] = @p3 WHERE [ID] = @p4", connection);
            adapter.DeleteCommand = new SqlCommand("DELETE FROM [personas_bd].[dbo].[personas] WHERE [ID] = @p4", connection);

            adapter.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar,50,"nombre");
            adapter.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            adapter.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");
            

            adapter.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            adapter.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            adapter.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");
            adapter.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int, 4, "ID");


            adapter.DeleteCommand.Parameters.Add("@p4", SqlDbType.Int, 4, "ID");
            
           

        }

        private void CargarDataTable()
        {
            this.Conectar();
            //this.comando.CommandType = CommandType.Text;
            //this.comando.CommandText = "SELECT TOP 1000[id] ,[nombre] ,[apellido] ,[edad] FROM[personas_bd].[dbo].[personas]";
            //this.lector = comando.ExecuteReader();
            //this.tablaPersonas.Load(this.lector);
            //this.lector.Close();
            this.connection.Close();
        }

        private void Conectar()
        {
            connection = new SqlConnection(Properties.Settings.Default.Conexion);
            connection.Open();
            this.comando = new SqlCommand();
            this.comando.Connection = connection;
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
            
            try
            {
                this.Conectar();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT TOP 1000[id] ,[nombre] ,[apellido] ,[edad] FROM[personas_bd].[dbo].[personas]";
                this.lector = comando.ExecuteReader();
                while (lector.Read() != false)
                {
                    MessageBox.Show(lector[0].ToString() + " - " +  lector[1].ToString() + " - " + 
                        lector[2].ToString() + " - " + lector[3].ToString());
                }
                connection.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Conectar();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM[personas_bd].[dbo].[personas]";
                this.lector = comando.ExecuteReader();
                frmVisorPersona frm = new frmVisorPersona(this.lista);


                //Se genera un nuevo objeto persona por cada elemento en la lista
                while (lector.Read() != false)
                {
                         Persona nuevaPersonita = new Persona(lector[1].ToString(), lector[2].ToString(), (int)lector[3]);
                         this.lista.Add(nuevaPersonita);
                       
                }

                //Lo cargo al visor

                frm.ActualizarListadoPersonas();
                frm.ShowDialog();
                lista = frm.miListaPersonas;
                connection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
           
        }

        private void bDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorDataTable frm = new frmVisorDataTable(this.tablaPersonas);

            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();
            this.tablaPersonas = frm.MiDataTable;
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Thread hilo = new Thread(this.ActualizarThread);
                hilo.Start();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

            //try
            //{

            //    adapter.Update(tablaPersonas);
            //}
            //catch(Exception a)
            //{
            //    MessageBox.Show(a.Message);
            //}

        }

        private void ActualizarThread()
        {
            try
            {
                adapter.Update(tablaPersonas);
                Thread.Sleep(30);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
