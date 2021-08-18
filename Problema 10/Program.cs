using System;

namespace Problema_10
{
    class Program
    {
        static void Main(string[] args)
        {
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
