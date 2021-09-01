using System;

namespace Problema_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Manuel Vanegas Tamara
            //Grupo: 239-2A
            //Turno: Diurno
            
            String Contra="";
            
            do{
                Console.WriteLine("Digite la contraseña");
                Contra=Console.ReadLine();
                if (Contra=="iloveyou123"){
                Console.WriteLine("Contraseña correcta");
                }
                else{
                    Console.WriteLine("Contraseña incorrecta, por favor ingresela de nuevo");
                }
            }while(Contra!="iloveyou123");
            
        }
    }
}
