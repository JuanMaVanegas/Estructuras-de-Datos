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

    /*Escriba un programa que dadas dos lista/pila/colaordenadas de números enteros, realice la concatenaciónen forma ordenada
     de ambas lista/pila/cola.*/

    class ejer_4
    {
        Queue cola1 = new Queue();
        Queue cola2 = new Queue();
        int rango, rango2, num, num2;

        public void proceso()
        {
            Console.WriteLine("-> Ingrese la medida de la 1 cola");
            rango = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int a = 0; a < rango; a++)
            {
                Console.WriteLine();
                Console.WriteLine($"Ingrese la pocision {a + 1} de la cola 1");
                num = int.Parse(Console.ReadLine());
                cola1.Enqueue(num);
            }
            Console.WriteLine();
            Console.WriteLine("-> Ingrese la medida de la 2 cola");
            rango2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int a = 0; a < rango2; a++)
            {
                Console.WriteLine();
                Console.WriteLine($"Ingrese laposion {a + 1} de la cola 2");
                num2 = int.Parse(Console.ReadLine());
                cola2.Enqueue(num2);
            }
            Console.WriteLine("De enter para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Estos son los valores de la cola 1:");
            foreach (int a in cola1)
            {
                Console.Write(a + " ");

            }
            Console.WriteLine("\n");
            Console.WriteLine("Estos son los valores de la cola 2:");
            foreach (int a in cola2)
            {
                Console.Write(a + " ");

            }
            Console.WriteLine("\n");
            Console.WriteLine("La concatenacion de las colas es: ");
            ArrayList conversion = new ArrayList(cola1);
            ArrayList conversion2 = new ArrayList(cola2);
            conversion.AddRange(conversion2);
            Queue cola3 = new Queue(conversion);
            foreach (int a in cola3)
            {
                Console.WriteLine("-" + a);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            ejer_4 agregar = new ejer_4();
            agregar.proceso();
           
        }
    }
}
