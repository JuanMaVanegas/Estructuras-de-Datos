using System;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Manuel Vanegas Tamara
            //Grupo: 239-2A
            //Turno: Diurno
            
            Console.WriteLine("Calificaciones de un Estudiante");
            int maxcal=0,mincal=100,i=0,nota=0,n;
            int prom;
            Console.WriteLine("Por favor digite las 4 calificaciones");
            while(i<4){
                i++;
                n=int.Parse(Console.ReadLine());
                nota=n+nota;
                if (n>maxcal){
                    maxcal = n;
                }
                if (n<mincal){
                    mincal = n;
                }
                }
            
            prom = nota / i;
            
            Console.WriteLine("El promedio del estudiante es "+prom);
            Console.WriteLine("La maxima calificacion es "+ maxcal);
            Console.WriteLine("La minima calificacion es "+ mincal);
        }
    }
}
