using System;
using System.Text;
using System.Globalization;

namespace AppendFormat
{
    class AppendFormat
    {
        /* INTEGRANTES DEL GRUPO:
               Johan Sebastián Ríos
               Luis Esteban Triana
               Juan Manuel Vanegas
               Andrés Santiago Villamil 
           Jornada:
               Diurna
           Grupo:
               63102C / 239 - 2A*/

        static StringBuilder nw = new StringBuilder();
        static void Main(string[] args)
        {
            
            string Nombre1 = "Roberta";
            string Nombre2 = "Jesus";
            string Nombre3 = "Marta";
            string [] Nombre4 = {"Jorge", "Rosalia", "Antonio"};

            
            Console.WriteLine("\nMetodo AppendFormat():");
            Console.WriteLine("\nPrimer Nombre: {0}",Nombre1);
            Console.WriteLine("Segundo Nombre: {0}",Nombre2);
            Console.WriteLine("Tercer Nombre: {0}",Nombre3);
            Console.WriteLine("Vector con Nombres: {0} , {1} , {2} ",Nombre4[0],Nombre4[1],Nombre4[2]);

            Console.WriteLine("\nConcatenación");
            Console.WriteLine("");

            nw.AppendFormat("1) {0}", Nombre1);
            Console.WriteLine(nw.ToString());
            nw.Length = 0;

            nw.AppendFormat("2) {0}, {1}", Nombre1, Nombre2);
            Console.WriteLine(nw.ToString());
            nw.Length = 0;

            nw.AppendFormat("3) {0}, {1}, {2}", Nombre1, Nombre2, Nombre3);
            Console.WriteLine(nw.ToString());
            nw.Length = 0;

            nw.AppendFormat("4) {0}, {1}, {2}", Nombre4);
            Console.WriteLine(nw.ToString());

            Console.WriteLine();
        }
    }
}
