using System;

namespace Problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Manuel Vanegas Tamara
            //Grupo: 239-2A
            //Turno: Diurno
            
            int VA,VB,VC,TotalVentas,ciclo=1;
            string salir=" ";
            float Media;
            
            do{
            Console.WriteLine ("Por favor ingrese las ventas de cada producto ");
            Console.WriteLine ("Ventas Producto A " );
            VA= int.Parse (System.Console.ReadLine());
            Console.WriteLine ("Ventas Producto B  " );
            VB= int.Parse (System.Console.ReadLine());
            Console.WriteLine ("Ventas Producto C  " );
            VC= int.Parse (System.Console.ReadLine());

            TotalVentas=VA+VB+VC;
            Media=TotalVentas/3;
           
            if (VA>VB && VA>VC)
            {
                Console.WriteLine ("\nEl producto A es quien tiene mas ventas");
            }

            if (VA>=200 && VB>=200 && VC>=200)
            {
                Console.WriteLine ("\nNingún producto tiene unas ventas inferiores a 200 ");
            }
          
            if (VA >=400 || VB>=400 || VC>=400)
            {
                Console.WriteLine ("\nAlgún producto tiene unas ventas superiores a 400 ");            
            }

            if (Media >=500)
            {
                Console.WriteLine ("\nLa media de ventas es superior a 500 ");
            }

            if (VB<VA && VB<VC)
            {
                Console.WriteLine ("\nEl producto B no es el más vendido ");
            }

            if (TotalVentas>=500 && TotalVentas<=1000)
            {
                Console.WriteLine ("\nEL total de ventas esta entre 500 y 1000 ");
            }

            Console.WriteLine("\nSi deseas salir marca S de lo contrario N");
            salir= Console.ReadLine();
            if (salir == "S" || salir == "s"){
                    ciclo=0;
                }
            }while (ciclo!=0);
        Console.WriteLine("Hasta Pronto");
        }
    }
}
