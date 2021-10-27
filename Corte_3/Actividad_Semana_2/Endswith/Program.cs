using System;

namespace Endswith
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
            string palabra;

            Console.WriteLine("Ejemplo de uso del metodo EndsWith()");
            Console.WriteLine("Por favor escriba una palabra en minuscula:");
            palabra = Console.ReadLine();

            if (palabra.EndsWith("a")|| palabra.EndsWith("e")|| palabra.EndsWith("i")|| palabra.EndsWith("o")|| palabra.EndsWith("u"))
            {
                Console.WriteLine("La palabra termina en una vocal");
            }
            else
            {
                Console.WriteLine("La palabra no termina con una vocal");
            }

            Console.ReadKey();
        }
    }
}
