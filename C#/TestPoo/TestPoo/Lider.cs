using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPoo
{
  class Lider : CAsociado
  {
    public Lider() : base()
    {      
      this.Sueldo = "17 000 $";
    }
    public bool IsAdmin { get; set; }
    public string Prestaciones { get; set; }

    protected new void doSomething() 
    {
      //

      base.doSomething();

      //do something
    }
  }
}
