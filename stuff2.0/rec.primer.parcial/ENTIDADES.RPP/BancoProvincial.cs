using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
  public class BancoProvincial : BancoNacional
  {
    protected string _provincia;

    public BancoProvincial(BancoNacional bancoNacional ,string provincia) 
    {
      this._provincia = provincia;
    }
  }
}
