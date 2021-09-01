/*INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil 
  Jornada:
        Diurna
   Grupo:
        63102C / 239 - 2A */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 3.Escriba un programa que pida dos números enteros mayores a 100 y que me dé la opción de calcular su:
/// suma, resta, divisióno multiplicación desde un menú
///(si ingresan un número diferente (real, cero)o letra por favor indicarlo al usuario).
namespace FuncionValorAbsoluto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero2, r;

            Console.WriteLine("Ingresa la opcion que quiere realizar \n" + "\n1.-suma" + "\n2.-resta"
                + "\n3.-multiplicacion" + "\n4.-division" + "\n5.-salir\n");
            string nro = null;
            nro = Console.ReadLine();
            switch (nro)
            {
                case "1":
                    Console.WriteLine(" favor ingresar un numero mayor a 100 : ");
                    numero = int.Parse(Console.ReadLine());


                    if (numero < 100)
                    {
                        Console.WriteLine(" La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero = int.Parse(Console.ReadLine());
                    }


                    Console.WriteLine(" favor ingresar otro numero mayor a 100 : ");
                    numero2 = int.Parse(Console.ReadLine());
                    if (numero2 < 100)
                    {
                        Console.WriteLine("La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero2 = int.Parse(Console.ReadLine());
                    }

                    r = (numero + numero2);
                    Console.Write("La suma es: {0} ", r);
                    break;
                case "2":
                    Console.WriteLine(" favor ingresar un numero mayor a 100 : ");
                    numero = int.Parse(Console.ReadLine());


                    if (numero < 100)
                    {
                        Console.WriteLine("La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero = int.Parse(Console.ReadLine());
                    }


                    Console.WriteLine(" favor ingresar otro numero mayor a 100 : ");
                    numero2 = int.Parse(Console.ReadLine());
                    if (numero2 < 100)
                    {
                        Console.WriteLine("La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero2 = int.Parse(Console.ReadLine());
                    }

                    r = (numero - numero2);
                    Console.Write("La resta es: {0} ", r);
                    break;
                case "3":
                    Console.WriteLine(" favor ingresar un numero mayor a 100 : ");
                    numero = int.Parse(Console.ReadLine());


                    if (numero < 100)
                    {
                        Console.WriteLine("La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero = int.Parse(Console.ReadLine());
                    }


                    Console.WriteLine(" favor ingresar otro numero mayor a 100 : ");
                    numero2 = int.Parse(Console.ReadLine());
                    if (numero2 < 100)
                    {
                        Console.WriteLine("La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero2 = int.Parse(Console.ReadLine());
                    }

                    r = (numero * numero2);
                    Console.Write("La multiplicacion es: {0} ", r);
                    break;
                case "4":
                    Console.WriteLine(" favor ingresar un numero mayor a 100 : ");
                    numero = int.Parse(Console.ReadLine());


                    if (numero < 100)
                    {
                        Console.WriteLine("La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero = int.Parse(Console.ReadLine());
                    }


                    Console.WriteLine(" favor ingresar otro numero mayor a 100 : ");
                    numero2 = int.Parse(Console.ReadLine());
                    if (numero2 < 100)
                    {
                        Console.WriteLine("La respuesta no es la que se esperaba: favor ingresar un numero mayor a 100 : ");
                        numero2 = int.Parse(Console.ReadLine());
                    }

                    r = (numero / numero2);
                    Console.Write("La divicion es: {0} ", r);
                    break;
                case "5":
                    Console.Write("salir");
                    break;
                default:
                    Console.WriteLine("elije una opcion de 1 a 5");
                    break;
            }
            Console.ReadKey();
        }
    }
}



