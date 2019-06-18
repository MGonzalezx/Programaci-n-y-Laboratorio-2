using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase20.WindowsForm
{
  public class Manejadora
  {
    public static void Manejador(object sender, EventArgs e)
    {
      MessageBox.Show("Mensaje por Manejadora estatico");
    }


    //public void Manejador2(object sender, EventArgs e)
    //{
    //  Manejador2 = new Action<object, EventArgs>()

    //}


  }
}
