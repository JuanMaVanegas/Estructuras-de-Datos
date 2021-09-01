using System;
/*INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil 
  Jornada:
        Diurna
   Grupo:
        63102C / 239-2A */

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0,n1=0,n2=0,n3=0,opc=0;
            
            Console.WriteLine("Numero Mayor o Numero Menor");
            Console.WriteLine("Ingrese numero 1");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero 4");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n==n1 && n==n2 && n==n3)
            {
                Console.WriteLine("Hay un numero Repetido");
            }else
            {
                if (n1==n && n1==n2 && n1==n3)
                {
                    Console.WriteLine("Hay un numero Repetido");
                }else
                {
                    if (n2==n && n2==n1 && n2==n3)
                    {
                        Console.WriteLine("Hay un numero Repetido");
                    }else
                    {
                        if (n3==n && n3==n1 && n3==n2)
                        {
                            Console.WriteLine("Hay un numero Repetido");
                        }else
                        {
                            Console.WriteLine("Menu");
                            Console.WriteLine("1.Mayor numero");
                            Console.WriteLine("2.Menor numero");
                            Console.WriteLine("Ingrese opcion");
                            opc = Convert.ToInt32(Console.ReadLine());
                            
                            switch(opc)
                            {
                              case 1:
                                if (n>n1 && n>n2 && n>n3)
                                {
                                    if (n1>n2 && n1>n3)
                                    {
                                        if (n2>n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n1,n2,n3);
                                        }
                                        if (n3>n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n1,n3,n2);
                                        }
                                    }
                                    if (n2>n1 && n2>n3)
                                    {
                                        if (n1>n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n2,n1,n3);
                                        }
                                        if (n3>n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n2,n3,n1);
                                        }
                                    }
                                    if (n3>n1 && n3>n2)
                                    {
                                        if (n1>n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n3,n1,n2);
                                        }
                                        if (n2>n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n3,n2,n1);
                                        }   
                                    }
                                }
                                if (n1>n && n1>n2 && n1>n3)
                                {
                                    if (n>n2 && n>n3)
                                    {
                                        if (n2>n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n,n2,n3);
                                        }
                                        if (n3>n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n,n3,n2);
                                        }
                                    }
                                    if (n2>n && n2>n3)
                                    {
                                        if (n>n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n2,n,n3);
                                        }
                                        if (n3>n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n2,n3,n);
                                        }
                                    }
                                    if (n3>n && n3>n2)
                                    {
                                        if (n>n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n3,n,n2);
                                        }
                                        if (n2>n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n3,n2,n);
                                        }   
                                    }
                                }
                                if (n2>n && n2>n1 && n2>n3)
                                {
                                    if (n>n1 && n>n3)
                                    {
                                        if (n1>n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n,n1,n3);
                                        }
                                        if (n3>n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n,n3,n1);
                                        }
                                    }
                                    if (n1>n && n1>n3)
                                    {
                                        if (n>n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n1,n,n3);
                                        }
                                        if (n3>n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n1,n3,n);
                                        }
                                    }
                                    if (n3>n1 && n3>n2)
                                    {
                                        if (n1>n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n3,n1,n);
                                        }
                                        if (n>n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n3,n,n1);
                                        }   
                                    }
                                }
                                if (n3>n && n3>n1 && n3>n2)
                                {
                                    if (n1>n && n1>n2)
                                    {
                                        if (n2>n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n1,n2,n);
                                        }
                                        if (n>n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n1,n,n2);
                                        }
                                    }
                                    if (n2>n1 && n2>n)
                                    {
                                        if (n1>n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n2,n1,n);
                                        }
                                        if (n>n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n2,n,n1);
                                        }
                                    }
                                    if (n>n1 && n>n2)
                                    {
                                        if (n1>n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n,n1,n2);
                                        }
                                        if (n2>n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n,n2,n1);
                                        }   
                                    }
                                }
                              break;
                              case 2:
                                if (n<n1 && n<n2 && n<n3)
                                {
                                    if (n1<n2 && n1<n3)
                                    {
                                        if (n2<n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n1,n2,n3);
                                        }
                                        if (n3<n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n1,n3,n2);
                                        }
                                    }
                                    if (n2<n1 && n2<n3)
                                    {
                                        if (n1<n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n2,n1,n3);
                                        }
                                        if (n3<n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n2,n3,n1);
                                        }
                                    }
                                    if (n3<n1 && n3<n2)
                                    {
                                        if (n1<n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n3,n1,n2);
                                        }
                                        if (n2<n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n,n3,n2,n1);
                                        }   
                                    }
                                }
                                if (n1<n && n1<n2 && n1<n3)
                                {
                                    if (n<n2 && n<n3)
                                    {
                                        if (n2<n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n,n2,n3);
                                        }
                                        if (n3<n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n,n3,n2);
                                        }
                                    }
                                    if (n2<n && n2<n3)
                                    {
                                        if (n<n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n2,n,n3);
                                        }
                                        if (n3<n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n2,n3,n);
                                        }
                                    }
                                    if (n3<n && n3<n2)
                                    {
                                        if (n<n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n3,n,n2);
                                        }
                                        if (n2<n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n1,n3,n2,n);
                                        }   
                                    }
                                }
                                if (n2<n && n2<n1 && n2<n3)
                                {
                                    if (n<n1 && n<n3)
                                    {
                                        if (n1<n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n,n1,n3);
                                        }
                                        if (n3<n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n,n3,n1);
                                        }
                                    }
                                    if (n1<n && n1<n3)
                                    {
                                        if (n<n3)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n1,n,n3);
                                        }
                                        if (n3<n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n1,n3,n);
                                        }
                                    }
                                    if (n3<n1 && n3<n2)
                                    {
                                        if (n1<n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n3,n1,n);
                                        }
                                        if (n<n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n2,n3,n,n1);
                                        }   
                                    }
                                }
                                if (n3<n && n3<n1 && n3<n2)
                                {
                                    if (n1<n && n1<n2)
                                    {
                                        if (n2<n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n1,n2,n);
                                        }
                                        if (n<n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n1,n,n2);
                                        }
                                    }
                                    if (n2<n1 && n2<n)
                                    {
                                        if (n1<n)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n2,n1,n);
                                        }
                                        if (n<n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n2,n,n1);
                                        }
                                    }
                                    if (n<n1 && n<n2)
                                    {
                                        if (n1<n2)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n,n1,n2);
                                        }
                                        if (n2<n1)
                                        {
                                            Console.WriteLine("El numero mayor conformado es: {0}{1}{2}{3}",n3,n,n2,n1);
                                        }   
                                    }
                                }
                              break;   
                            }
                            
                        }    
                    }                    
                }    
            }
        }
    }
}
