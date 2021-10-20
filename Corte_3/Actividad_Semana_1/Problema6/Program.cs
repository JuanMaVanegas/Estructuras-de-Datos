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

    /*Escriba una rutina que reciba una PilaP de números enteros y mueva sus elementos a una nueva Pila, pero invirtiendo
    el orden de salida de estos. Alfinalizar la Pila P no debe contener elementos.*/

    class ejer_6
    {
        static void Main(string[] args)
        {
            int Cantidad = 0, Dato = 0;
            Queue lista = new Queue();
            Queue listacol = new Queue();
            Queue nuevalistacol = new Queue();

                    Console.WriteLine("cantidad de numeros que va ingresar:");
                    Cantidad = int.Parse(Console.ReadLine());

                                Console.WriteLine("************************************");
                                Console.WriteLine("Ingrese los numeros:");
                    for (int a = 0; a < Cantidad; a++)
                    {
                        Console.Write("* ");
                        Dato = int.Parse(Console.ReadLine());
                        lista.Enqueue(Dato);
                    }

            foreach (int a in lista)
            {
                listacol.Enqueue(a);
            }
            Console.WriteLine("Los valores ahora estan en otra cola y estos son:");

                    foreach (int e in listacol)
                    {
                        nuevalistacol.Enqueue(e);
                    }
                    foreach (int l in nuevalistacol)
                    {
                        Console.WriteLine($"* {l}");
                    }
                                ArrayList num = new ArrayList(nuevalistacol);
                                num.Reverse();
                                Queue cola2 = new Queue(num);
                                Console.WriteLine("Valores invertidos:");
            foreach (int q in cola2)
            {
                Console.WriteLine($"* {q}");
            }
        }
    }
}
