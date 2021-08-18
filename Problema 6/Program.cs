using System;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de segundos a convertir");
            int segundos,dias,horas,minutos;
            segundos=int.Parse(Console.ReadLine());

            dias = segundos/(24 * 60 * 60);
            segundos = segundos%(24 * 60 * 60);
            horas = segundos / (60 * 60);
            segundos = segundos % (60 * 60);
            minutos = segundos / 60;
            segundos = segundos % 60;

            Console.WriteLine("{0} Dias - {1} Horas - {2} Minutos - {3} Segundos ",dias,horas,minutos,segundos);
        }
    }
}
