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

namespace Ejercicio_xtrazo
{

    /*.Escriba una rutina que reciba una Pila P de números enteros y mueva sus elementos a una nueva Pila, pero manteniendo el orden de salida
    de estos.Al finalizar la PilaP no debe contener elementos.*/

    class ejer_5
    {
        static void Main(string[] args)
        {
            int numero = 0, cantidadcol = 0;

            Queue cola = new Queue();
            Queue nuevacola = new Queue();

            Console.WriteLine("Numero de los datos que desea ingresar");
            cantidadcol = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < cantidadcol; cont++)
            {
                Console.Write("* ");
                numero = int.Parse(Console.ReadLine());
                cola.Enqueue(numero);
            }

            Console.WriteLine("Los valores de la cola seran transferidos a una nueva cola");
            Console.WriteLine("*************************************************************");

            foreach (int s in cola)
            {
                nuevacola.Enqueue(s);
            }

            Console.WriteLine("La nueva cola tiene {0} datos y sus valores son:", nuevacola.Count);
            foreach (int e in nuevacola)
            {
                Console.WriteLine("- {0}", e);
            }
            Console.WriteLine(" ***********************************************");

        }
    }
}
