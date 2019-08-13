using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPoo
{
  class CAsociado
  {

    public CAsociado() {
      _Sueldo = "16 000 $";
    }

    private string _Sueldo;

    internal string Puesto {get; set; }
    public string Horas { get; set; }

    public string Sueldo {
      get { return _Sueldo; }
      set { _Sueldo = $"{value} $"; }
    }

    protected void doSomething()
    {
      //something
    }
  }
}
