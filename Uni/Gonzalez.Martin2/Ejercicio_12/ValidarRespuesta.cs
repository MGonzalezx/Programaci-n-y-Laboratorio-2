using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool retorno = true;
            char.IsLetter(c);
            if(c == 's' || c == 'S')
            {
                return retorno;
            }else
            {
                retorno = false;
                return retorno;
            }
               
        }
    }
}
