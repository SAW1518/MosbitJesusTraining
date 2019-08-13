using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CProyecto> Lists = new List<CProyecto>();
            String Day, Month, Year;

            for (; ; ) {
                int op;
                Console.WriteLine("Reguistro de Proyectos ");
                Console.WriteLine("1-Reguistrar ");
                Console.WriteLine("2-Liatar");
                op = Int32.Parse(Console.ReadLine());
                switch (op)
                   
                {
                    case 1:
                        List<CAsociado> ListsA = new List<CAsociado>();
                        List<Lider> ListsL = new List<Lider>();
                        int Asociado , Lideres;
                        string Sueldo;
                        CProyecto C = new CProyecto();
                        Console.WriteLine("Introduzca Nombre Del Proyecto ");
                        C.Name1 = Console.ReadLine();
                        Console.WriteLine("Introduzca Nombre Del Cliente ");
                        C.NameClient1 = Console.ReadLine();
                        Console.WriteLine("Introduzca Plataforma ");
                        C.Plataform1 = Console.ReadLine();
                        Console.WriteLine("Introduzca Asociados1 ");

                        Asociado = Int32.Parse(Console.ReadLine());
                        C.Asociados1 = Asociado;

                        Console.WriteLine("Fecha de Entrega");
                        Console.Write("Dia: ");
                        Day = Console.ReadLine();
                        Console.Write("Mes: ");
                        Month = Console.ReadLine();
                        Console.Write("Year: ");
                        Year = Console.ReadLine();
                        C.SetDataRelise(Day, Month, Year);
                        string DATA = C.getDataRelise();

                        Console.WriteLine("Reguistro de asociados : " + Asociado);
                        Console.Write("Lideres ?:  " );
                        Lideres = Int32.Parse(Console.ReadLine());
                        for (int x= 0; x< Lideres; x++)
                        {
                            Lider L = new Lider();
                            L.IsAdmin = true;
                            Console.WriteLine("Reguistro de pretaciones");
                            L.Prestaciones = Console.ReadLine();
                            L.Puesto = "Lider";


                            Console.WriteLine("Reguistro el sueldo");
                            Sueldo = Console.ReadLine();
                           
                           L.Sueldo = Sueldo;
                           
                            
                            Console.WriteLine("Reguistro el numero de Horas ");
                            L.Horas =Console.ReadLine();
                            ListsL.Add(L);

                        }

                        Console.Write("Desarrolladoes  ?:  " );
                       for(int x = 0; x < Asociado- Lideres; x++)
                        {
                            CAsociado CA = new CAsociado();
                            CA.Puesto = "Desarrollador";
                            Console.WriteLine("Reguistro el sueldo");
                            Sueldo = Console.ReadLine();
                            CA.Sueldo = Sueldo;
                            
                            Console.WriteLine("Reguistro el numero de Horas ");
                            CA.Horas = Console.ReadLine();
                            ListsA.Add(CA);
                        }

                        C.ListAsociad1 = ListsA;
                        C.ListLider1 = ListsL;

                        Lists.Add(C);
                        break;

                    case 2:
                        foreach (CProyecto CProyectoItem in Lists)
                        {
                            Console.WriteLine("Nombre del Proyecto: "+ CProyectoItem.Name1);
                            Console.WriteLine("Nombre del Cliente: " + CProyectoItem.NameClient1);
                            Console.WriteLine("Plataforma: " + CProyectoItem.Plataform1);
                            Console.WriteLine("Fecha de Lanzaminto: " + CProyectoItem.getDataRelise());
                            Console.WriteLine("Precio:" + CProyectoItem.Price);
                            CProyectoItem.mostrarListAsociad();
                            CProyectoItem.mostrarListLideres();


                        }
                        break;

                }


               
            }

        }
    }
}
