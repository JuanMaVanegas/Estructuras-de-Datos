using System;

namespace Compare
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
            string cadena1, cadena2;

            Console.WriteLine("Ejemplo de uso del metodo Concat()");
            Console.WriteLine("Por favor digite una cadena de texto y a continuacion otra");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Segunda cadena:");
            cadena2 = Console.ReadLine();

            int resultado;

            resultado = String.Compare(cadena1, cadena2);

            if (resultado == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas son distintas");
            }
        }
    }
}
