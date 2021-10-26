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
            string apellido = " Gonzales Prada ";

            Console.WriteLine("Este programa te descuenta los espacios en blanco en la palabra con el metodo trim ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Gonzales Prada ");
            Console.WriteLine("Sin metodo Trim = "+apellido.Length);
            Console.WriteLine("Metodo Trim = " + apellido.Trim().Length);
            Console.WriteLine("---------------------------------------");
            


            Console.ReadKey();        
        }
    }
}