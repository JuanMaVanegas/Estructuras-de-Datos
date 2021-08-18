using System;

namespace Problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Manuel Vanegas Tamara
            //Grupo: 239-2A
            //Turno: Diurno
            
            double edad_perro,edad_persona;
            Console.WriteLine("Digite la cantidad de años del perro");
            edad_perro=double.Parse(Console.ReadLine());
           

            if (edad_perro<=2){
                edad_persona=edad_perro*10.5;
            }
            else{
                edad_persona=21+(edad_perro-2)*4;
            }
            Console.WriteLine("El equivalente de "+edad_perro+" años perros a humanos es "+edad_persona);
        }
    }
}
