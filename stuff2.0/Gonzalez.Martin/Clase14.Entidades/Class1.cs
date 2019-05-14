using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14.Entidades
{

    public static class ParseadoraDeEnteros
    {
    static string messageCatch;
    static ParseadoraDeEnteros()
    {
      ParseadoraDeEnteros.messageCatch = "El string no podrá ser convertido";
    }

    public static int Parse(string numero)
    {
      try
      {
        return Int32.Parse(numero);
      }
      catch (FormatException a)
      {
        throw new ErrorParserException(messageCatch +"... por error de formato", a);
      }
      catch (OverflowException a)
      {
        throw new ErrorParserException(messageCatch + "... por tamaño del dato", a);
      }
      catch (Exception a)
      {
        throw new ErrorParserException(messageCatch, a);
      }
    }

    public static bool tryParse(string numero, out int salida)
    {
      try
      {
        salida = ParseadoraDeEnteros.Parse(numero);
        return true;
      }
      catch (Exception e)
      {
        throw new ErrorParserException("El string no podrá ser convertido", e);
      }
    }
    }
}
