using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplotostring
{
    class Program
    {
        static void Main(string[] args)
            {
            Estudiante e1 = new Estudiante();
            Estudiante e2 = new Estudiante();
            e1.DameNombre = "Esteban  ";
            e1.DameCalificacion = 4.5;
            e2.DameNombre = "Luna  ";
            e2.DameCalificacion = 4.1;
            Console.WriteLine(e1.ToString());
            Console.WriteLine("-----------------------------");
            Console.WriteLine(e2);
            Console.ReadKey();

            
    }
    }
}
