using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public class Ticketeadora
    {
        public static bool ImprimirTicket(Cartuchera<Goma> cartuchera)
        {
            bool sePudo = false;

            try
            {
                using (StreamWriter escritor = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\tickets.log", true))
                {
                    escritor.WriteLine(DateTime.Now);
                    escritor.WriteLine("Precio total de la cartuchera: $" + cartuchera.PrecioTotal);
                    sePudo = true;
                }
            }
            catch (Exception error)
            {
               
            }

            return sePudo;
        }
    }
}
