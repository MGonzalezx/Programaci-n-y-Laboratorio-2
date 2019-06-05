using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTIDADES.RPP
{
  public class ClaseConstructores
  {

    static ClaseConstructores()
    {
      MessageBox.Show("pase por un constructor estático");
    }
    
      private ClaseConstructores(string a, int b)
    {
      MessageBox.Show("pase por un constructor que reciba 2 parámetros (privado)"+ a + b);
    }

    public ClaseConstructores()
    {
      MessageBox.Show("pase por un constructor publico (default)");
    }
  }
}
