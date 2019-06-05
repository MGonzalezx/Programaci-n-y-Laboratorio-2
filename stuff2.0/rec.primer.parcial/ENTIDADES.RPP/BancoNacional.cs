using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
  public class BancoNacional : Banco
  {
    protected string _pais;

    public BancoNacional(string nombre, string pais) : base(nombre)
    {
      this._pais = pais;
    }
  }
}
