using System;

namespace Substring
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
    class Program
    {
        static void Main(string[] args)
        {
            string cad,sub;

            Console.WriteLine("Ejemplo de uso del metodo Substring()");
            Console.WriteLine("==================================================================================");
            cad = ("Este es el ejemplo de una cadena completamente normal \n");
            Console.WriteLine(cad);
            sub = cad.Substring(33, 13);
            Console.WriteLine("A continuacion una subcadena de la cadena anterior utilizando los indices (33, 13) => " + sub);

            Console.ReadKey();
        }
    }
}
