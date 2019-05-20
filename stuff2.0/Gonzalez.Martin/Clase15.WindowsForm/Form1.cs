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

namespace Clase15.WindowsForm
{
    public partial class frmPrincipal : Form
    {
        private string rutaDeAcceso;

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Puedo establacer u obtener el directorio inicial cuando buscamos
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Cambia el titulo de la ventana
            this.openFileDialog1.Title = "¿Donde desea guardar?";
            //Al apretar ctrl o shift seleccione màs archivos
            this.openFileDialog1.Multiselect = true;
            //Que busque determinadas extensiones
            this.openFileDialog1.DefaultExt = ".txt";
            //Cuando buscamos por el nombre, nos agrega la extensiòn.
            this.openFileDialog1.AddExtension = true;
            //Que busque SOLAMENTE las extensiones
            this.openFileDialog1.Filter = "(*.txt) | *.txt";
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.rutaDeAcceso))
            {
                try
                {
                    //StreamWriter Archivo = new StreamWriter(Path, Append);

                    //Decirle al compilado que la m no es una barra de escape como \n
                    //Una forma de solucionarlo es poniendo otra barra. Si hay varias subcarpetas tengo que poner muchas \\
                    //Asi que en paths màs largas no sirve
                    //La otra forma es ponerle un @ por afuera del string

                    //StreamWriter Archivo = new StreamWriter(@"D:\MiArchivo.txt", true);

                    //Otra forma de hacerlo.
                    //StreamWriter Archivo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\MiArchivo.txt", true);

                    //PARA PONERLO EN EL ESCRITORIO
                    //StreamWriter Archivo = new StreamWriter(@"C:\Users\alumno\Desktop\Escritorio.txt", true);

                    //Independientemente del usuario que esta usando la aplicaciòn te lleva al archivo
                    //StreamWriter Archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Escritorio2.txt", true); 
                    StreamWriter Archivo = new StreamWriter(this.rutaDeAcceso, true);
                    //Write()
                    //WriteLine()
                    Archivo.WriteLine(txtValor.Text);
                    Archivo.Close();
                }
                catch (Exception Algo)
                {
                    txtValor.Text = "Error";
                }
            }
            else
            {
                MessageBox.Show("Debe especificar una ruta de acceso");
            }




        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.rutaDeAcceso))
            {
                try
                {
                    //StreamReader Archivo = new StreamReader(@"D:\MiArchivo.txt");

                    //PARA LEER DEL ESCRITORIO
                    //StreamReader Archivo = new StreamReader(@"C:\Users\alumno\Desktop\Escritorio.txt");

                    //StreamReader Archivo = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Escritorio2.txt");
                    StreamReader Archivo = new StreamReader(this.rutaDeAcceso);
                    //Read() lee por letra
                    //ReadToEnd() lee desde el primer caracter hasta el ultimo como un solo string
                    //ReadLine() lee una linea del archivo del texto hasta que encuentre un enter.
                    //Vamos a tener que usarlo en una estructura repetitiva ara que los lea por separado
                    //Close para cerrar
                    string l;
                    //Para mostrar todas las lineas del archivo
                    while ((l = Archivo.ReadLine()) != null)
                    {
                        this.lstVisor.Items.Add(l);
                    }

                    Archivo.Close();
                }
                catch (Exception Alguito)
                {
                    txtValor.Text = "Error";
                }
            }
            else
            {
                MessageBox.Show("Debe especificar una ruta de acceso");
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Es como abrir un archivo de windows, cuando ponemos explorar.
            DialogResult resultado = this.openFileDialog1.ShowDialog();
            //Al hacer este if, nos ayuda a que no nos muestre nada al cancelar or cerrar la ventana
            if (resultado == DialogResult.OK)
            {
                //Me muestra el nombre del archivo seleccinado
                //MessageBox.Show(this.openFileDialog1.FileName);
                this.rutaDeAcceso = this.openFileDialog1.FileName;

            }

        }


    }
}
