using System;
using System.Text;
using System.Globalization;

namespace ToString1
{
    class ToString1
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

        static StringBuilder tostring = new StringBuilder();

        static void Main(string[] args)
        {
            string Num1 = "123";
            string Num2 = "456";
            string Num3 = "789";
            string [] Num4 = {"10", "11", "12"};

            
            Console.WriteLine("\nMetodo ToString():");
            Console.WriteLine("\nPrimer Número: {0}",Num1);
            Console.WriteLine("Segundo Número: {0}",Num2);
            Console.WriteLine("Tercer Número: {0}",Num3);
            Console.WriteLine("Vector con Números: {0} , {1} , {2} ",Num4[0],Num4[1],Num4[2]);

            Console.WriteLine("\nConcatenación");
            Console.WriteLine("");

            tostring.AppendFormat("1) {0}", Num1);
            Console.WriteLine(tostring.ToString());
            Console.WriteLine("{0} CARACTERES", tostring.Length);
            tostring.Length = 0;

            tostring.AppendFormat("2) {0}, {1}", Num1, Num2);
            Console.WriteLine(tostring.ToString());
            Console.WriteLine("{0} CARACTERES", tostring.Length);
            tostring.Length = 0;

            tostring.AppendFormat("3) {0}, {1}, {2}", Num1, Num2, Num3);
            Console.WriteLine(tostring.ToString());
            Console.WriteLine("{0} CARACTERES", tostring.Length);
            tostring.Length = 0;

            tostring.AppendFormat("4) {0}, {1}, {2}", Num4);
            Console.WriteLine(tostring.ToString());
            Console.WriteLine("{0} CARACTERES", tostring.Length);

            Console.WriteLine();
            
        }
    }
}
