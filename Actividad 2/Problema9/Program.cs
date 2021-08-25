using System;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {

        /*INTEGRANTES DEL GRUPO:
            Johan Sebastian Rios
            Luis Esteban Triana
            Juan Manuel Vanegas
            Adres Santiago Villamil 
        Jornada:
            Diurna
        Grupo:
            63102C / 239-2A */   
            string n=" ";
            Console.WriteLine("Calcular el área de ");
            Console.WriteLine("1. Triángulo ");
            Console.WriteLine("2. Circulo ");
            Console.WriteLine("Si desea la opción 1 marca T y si desea la opción 2 marca C ");
            n = Console.ReadLine();
            
            double alt,bas,radio,areatr,areacr;

            if(n=="T" || n=="t"){
                Console.WriteLine("\nDigite la base");
                bas=float.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite la altura");
                alt=float.Parse(Console.ReadLine());
                areatr=(bas*alt)/2;
                Console.WriteLine("El área del triángulo es igual a "+areatr);
            }
            if (n=="C" || n=="c"){
                Console.WriteLine("\nDigite el radio");
                radio=float.Parse(Console.ReadLine());
                areacr= Math.PI * (radio*radio);
                Console.WriteLine("El área del circulo es igual a "+areacr);

            }
            

        }
    }
}
