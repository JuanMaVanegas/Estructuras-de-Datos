using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* INTEGRANTES DEL GRUPO:
               Johan Sebastián Ríos
               Luis Esteban Triana
               Juan Manuel Vanegas
               Andrés Santiago Villamil 
           Jornada:
               Diurna
           Grupo:
               63102C / 239 - 2A*/

namespace Ejercicio_x_trazo
{

    class trim
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Este programa te descuenta todos los espacios en blanco al final de la palabra, con el metodo  -> trimEnd <- ");
           
            Console.WriteLine("---------------------------------------");
            string objeto = "  No eres lo que logras, eres lo que superas.  ";

            Console.WriteLine("  Camino hacia el terror  ");
            Console.WriteLine("Sin metodo TrimEnd = " + objeto.Length);
            Console.WriteLine("Metodo TrimEnd = " + objeto.TrimEnd().Length);
            Console.WriteLine("---------------------------------------");


            Console.ReadKey();        
        }
    }
}