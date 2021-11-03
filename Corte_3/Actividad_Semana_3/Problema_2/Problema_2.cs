using System;
using System.Collections;

namespace Ejercicios
{
    class Operaciones
    {
             
        static void Main(string[] args)
        {
           ArrayList Numeros = new ArrayList();
           Random Aleatorio = new Random();
           Numeros.Add(Aleatorio.Next(0,100));
           Numeros.Add(Aleatorio.Next(0,100)); 
           
           Imprimir(Numeros);
           Suma(Numeros);
           Resta(Numeros);
           Multiplicacion(Numeros);
           Division(Numeros);
            
        }
        static void Imprimir (ArrayList lista)
        {
            Console.WriteLine("Los numeros son:");
            foreach (int n in lista)
            {
                Console.WriteLine(n);
            }   
        }
        static void Suma (ArrayList lista)
        {
            int suma=0;
            Console.WriteLine("La suma es:");
            foreach (int n in lista)
            {
                suma += n;
            }
            Console.WriteLine(suma);    
        }
        static void Resta (ArrayList lista)
        {
            int Resta=0;
            Console.WriteLine("La resta es:");
            foreach (int n in lista)
            {
                Resta = n - Resta;
            }
            Console.WriteLine(Resta);    
        }
        static void Multiplicacion (ArrayList lista)
        {
            int multiplica=1;
            Console.WriteLine("La multiplicacion es:");
            foreach (int n in lista)
            {
                multiplica = n * multiplica;
            }
            Console.WriteLine(multiplica);    
        }
        static void Division (ArrayList lista)
        {
            int dividir=1;
            Console.WriteLine("La division es:");
            foreach (int n in lista)
            {
                dividir = n / dividir;
            }
            Console.WriteLine(dividir);    
        }                              
    }
}

