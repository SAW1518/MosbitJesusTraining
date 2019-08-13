using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPoo
{
    class CProyecto : IDataRules
    {
       
        public string Name { get; set; }
        public string NameClient {get; set ;}
        public string Plataform { get; set; }

        private int Asociados;
        private List<CAsociado> ListAsociad;
        private List<Lider> ListLider;
        private DateTime DataRelise;
        private int price;

       
       
        public int Price { get => price; set => price = value; }
        public DateTime DataRelise1 { get => DataRelise; set => DataRelise = value; }
        public int Asociados1 { get => Asociados; set => Asociados = value; }
        public List<CAsociado> ListAsociad1 { set => ListAsociad = value; }
        public List<Lider> ListLider1 { set => ListLider = value; }

        public void SetDataRelise(string Day, string Month, string Year)
        {

            this.DataRelise = DateTime.Parse(Day + "/" + Month + "/" + Year);

        }

        public string getDataRelise()
        {
            return DataRelise.ToString();
        }

        public void mostrarListAsociad()
        {

            Console.WriteLine("Lista de Desarrolladores ");
            Console.WriteLine("----------------------------------------");
            foreach (CAsociado CAsociadoItem in ListAsociad)
            {
                Console.WriteLine("Puesto : "+ CAsociadoItem.Puesto);
                Console.WriteLine("Sueldo : "+ CAsociadoItem.Sueldo);
                Console.WriteLine("Horas  : "+ CAsociadoItem.Horas);
            }
            Console.WriteLine("----------------------------------------");

        }
        public void mostrarListLideres()
        {
            Console.WriteLine("Lista de Lideres ");
            Console.WriteLine("----------------------------------------");
            foreach (Lider LiderItem in ListLider)
            {

                Console.WriteLine("Prestaciones : " + LiderItem.Prestaciones);
                Console.WriteLine("Puesto : " + LiderItem.Puesto);
                Console.WriteLine("Sueldo : " + LiderItem.Sueldo);
                Console.WriteLine("Horas  : " + LiderItem.Horas);
            }
            Console.WriteLine("----------------------------------------");

        }
    }
}
