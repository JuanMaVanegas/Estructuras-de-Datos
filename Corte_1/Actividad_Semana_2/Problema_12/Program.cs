using System;

namespace Problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil 
        Jornada:
            Diurna
        Grupo:
            63102C / 239-2A */
            int a=0,b=0,c=0;
            double  resul=0.00f;
            
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Venta de cables");
            Console.WriteLine("1. Cable de television");
            Console.WriteLine("2. Cable de telefono");
            Console.WriteLine("3. Cable de internet");
            Console.WriteLine("Ingresar opcion: ");
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
            case 1:
                Console.WriteLine("Cable de television");
                Console.WriteLine("Ingrese los metros de cable");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio por metro");
                c = Int32.Parse(Console.ReadLine());
                if (b>=20 && b<40)
                {
                    resul = (b * c) - (b*c*0.5);
                    Console.WriteLine("los {0} metros de cable de television valen: {1}",b,resul);
                }
                if (b>40)
                {
                    resul = (b * c) - (b * c * 0.12);
                    Console.WriteLine("los {0} metros de cable de television valen: {1}",b,resul);
                }    

            break;
            case 2:
                Console.WriteLine("Cable de telefono");
                Console.WriteLine("Ingrese los metros de cable");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio por metro");
                c = Int32.Parse(Console.ReadLine());
                if (b>=20 && b<40)
                {
                    resul = (b * c) - (b*c*0.5);
                    Console.WriteLine("los {0} metros de cable de telefono valen: {1}",b,resul);
                }
                if (b>40)
                {
                    resul = (b * c) - (b * c * 0.12);
                    Console.WriteLine("los {0} metros de cable de telefono valen: {1}",b,resul);
                }
            break;
            case 3:
                Console.WriteLine("Cable de internet");
                Console.WriteLine("Ingrese los metros de internet");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio por metro");
                c = Int32.Parse(Console.ReadLine());
                if (b>=20 && b<40)
                {
                    resul = (b * c) - (b*c*0.5);
                    Console.WriteLine("los {0} metros de cable de internet valen: {1}",b,resul);
                }
                if (b>40)
                {
                    resul = (b * c) - (b * c * 0.12);
                    Console.WriteLine("los {0} metros de cable de internet valen: {1}",b,resul);
                }
            break;
            }
        }
    }
}
