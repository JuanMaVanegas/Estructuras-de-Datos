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
    /*Escriba un programa que inserte valores ordenadamente en una ista. La lista/pila/cola debe almacenar números enteros.
    El programa debe leer una secuencia de números enteros de la entrada hasta que se ingrese el número cero.*/

    class ejer_1
    {
        Queue cola = new Queue();
        int valor;
        public void ejercicio()
        {
            do
            {

                Console.WriteLine($"Ingrese el valor: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine();
                cola.Enqueue(valor);

            } while (valor != 0);
            Console.WriteLine("Estos son los numeros ingresados: ");
            foreach (int a in cola)
            {
                Console.Write(a + ". ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            ejer_1 llamado = new ejer_1();
            Console.WriteLine("Ingrese la cantidad que desee: ");
            Console.WriteLine("0 para salir");
            llamado.ejercicio();
            Console.WriteLine();
            Console.WriteLine("Fin del programa, de enter si quiere limpiar la pantalla");
            Console.ReadKey();
            Console.Clear();
        }
    }
}