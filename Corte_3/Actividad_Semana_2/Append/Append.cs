using System;

namespace Append
{
    class Append
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
               
        static void Main(string[] args)
        {
            Console.WriteLine("\nMetodo Append()");

            Console.WriteLine("\nCadena Original");
            string Cadena = "Mario;Ingenieria de Software;2 Semestre;Ucompensar";
            Console.WriteLine(cadena);

            int a = 0;
            System.Text.StringBuilder Agregar = new System.Text.StringBuilder();
            int x = Cadena.IndexOf(';', a);      
            Agregar.Append(Cadena, a, x).Append(" es estudiante de: ");
            a += x + 1;
            x = Cadena.IndexOf(';', a) - a;
            Agregar.Append(Cadena, a, x).Append(", esta en el ");
            a += x + 1;
            x = Cadena.IndexOf(';', a) - a;
            Agregar.Append(Cadena, a, x).Append(", en la Universidad de ");
            a += x + 1;
            Agregar.Append(Cadena, a, Cadena.Length - a);

            Console.WriteLine("\nCadena con el metodo Append")
            Console.WriteLine("{0}",Agregar);
            Console.WriteLine("");
        }
    }
}
