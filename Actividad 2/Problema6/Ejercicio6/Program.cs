using System;

namespace Ejercicio6
{ 
    /*
    INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil
    Jornada:
        Diurna
    Grupo:
        63102C / 239-2A
    */
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("1-Convertir numeros en letras:");
            Console.WriteLine("2-Convertir letras a numeros:");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("\n1-Convertir numeros en letras:");
                int numero;
                numero = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (numero == 1)
                    {
                        Console.Write("UNO");
                        numero = numero - 1;
                    }
                    if (numero == 2)
                    {
                        Console.Write("DOS");
                        numero = numero - 2;
                    }
                    if (numero == 3)
                    {
                        Console.Write("TRES");
                        numero = numero - 3;
                    }
                    if (numero == 4)
                    {
                        Console.Write("CUATRO");
                        numero = numero - 4;
                    }
                    if (numero == 5)
                    {
                        Console.Write("CINCO");
                        numero = numero - 5;
                    }
                    if (numero == 6)
                    {
                        Console.Write("SEIS");
                        numero = numero - 6;
                    }
                    if (numero == 7)
                    {
                        Console.Write("SIETE");
                        numero = numero - 7;
                    }
                    if (numero == 8)
                    {
                        Console.Write("OCHO");
                        numero = numero - 8;
                    }
                    if (numero == 9)
                    {
                        Console.Write("NUEVE");
                        numero = numero - 9;
                    }
                    if (numero == 10)
                    {
                        Console.Write("DIEZ");
                    }
                    if (numero == 11)
                    {
                        Console.Write("ONCE");
                        break;
                    }
                    if (numero == 12)
                    {
                        Console.Write("DOCE");
                        break;
                    }
                    if (numero == 13)
                    {
                        Console.Write("TRECE");
                    }
                    if (numero == 14)
                    {
                        Console.Write("CATORCE");
                    }
                    if (numero == 15)
                    {
                        Console.Write("QUINCE");
                    }
                    if (numero == 20)
                    {
                        Console.Write("VEINTE");
                        numero = numero - 20;
                    }
                    if (numero == 30)
                    {
                        Console.Write("TREINTA");
                        numero = numero - 30;
                    }
                    if (numero == 40)
                    {
                        Console.Write("CUARENTA");
                        numero = numero - 40;
                    }
                    if (numero == 50)
                    {
                        Console.Write("CINCUENTA");
                        numero = numero - 50;
                    }
                    if (numero == 60)
                    {
                        Console.Write("SESENTA");
                        numero = numero - 60;
                    }
                    if (numero == 70)
                    {
                        Console.Write("SETENTA");
                        numero = numero - 70;
                    }
                    if (numero == 80)
                    {
                        Console.Write("OCHENTA");
                        numero = numero - 80;
                    }
                    if (numero == 90)
                    {
                        Console.Write("NOVENTA");
                        numero = numero - 90;
                    }
                    if (numero == 100)
                    {
                        Console.Write("CIEN");
                        numero = numero - 100;
                    }
                    if (numero > 15 && numero < 20)
                    {
                        Console.Write("DIECI");
                        numero = numero -10;
                        continue;
                    }
                    if (numero > 20 && numero < 30)
                    {
                        Console.Write("VEINTI");
                        numero = numero - 20;
                        continue;
                    }
                    if (numero > 30 && numero < 40)
                    {
                        Console.Write("TREINTA Y ");
                        numero = numero - 30;
                        continue;
                    }
                    if (numero > 40 && numero < 50)
                    {
                        Console.Write("CUARENTA Y ");
                        numero = numero - 40;
                        continue;
                    }
                    if (numero > 50 && numero < 60)
                    {
                        Console.Write("CINCUENTA Y ");
                        numero = numero - 50;
                        continue;
                    }
                    if (numero > 60 && numero < 70)
                    {
                        Console.Write("SESENTA Y ");
                        numero = numero - 60;
                        continue;
                    }
                    if (numero > 70 && numero < 80)
                    {
                        Console.Write("SETENTA Y ");
                        numero = numero - 70;
                        continue;
                    }
                    if (numero > 80 && numero < 90)
                    {
                        Console.Write("OCHENTA Y ");
                        numero = numero - 80;
                        continue;
                    }
                    if (numero > 90 && numero < 100)
                    {
                        Console.Write("NOVENTA Y ");
                        numero = numero - 90;
                        continue;
                    }
                    if (numero < 0 || numero > 100)
                    {
                        Console.WriteLine("El numero debe de estar en un rango del 1 al 100");
                        Console.WriteLine("Digite el numero nuevamente:");
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                } while (numero != 0);
            }

            if (opcion == 2)
            {
                Console.WriteLine("\n2-Convertir letras a numeros:");
                string numero;
                numero = Console.ReadLine();
                
                if (numero == "Uno" || numero == "UNO" || numero == "uno")
                {
                    Console.WriteLine("Numero: 1");
                }
                if (numero == "Dos" || numero == "DOS" || numero == "dos")
                {
                    Console.WriteLine("Numero: 2");
                }
                if (numero == "Tres" || numero == "TRES" || numero == "tres")
                {
                    Console.WriteLine("Numero: 3");
                }
                if (numero == "Cuatro" || numero == "CUATRO" || numero == "cuatro")
                {
                    Console.WriteLine("Numero: 4");
                }
                if (numero == "Cinco" || numero == "CINCO" || numero == "cinco")
                {
                    Console.WriteLine("Numero: 5");
                }
                if (numero == "Seis" || numero == "SEIS" || numero == "seis")
                {
                    Console.WriteLine("Numero: 6");
                }
                if (numero == "Siete" || numero == "SIETE" || numero == "siete")
                {
                    Console.WriteLine("Numero: 7");
                }
                if (numero == "Ocho" || numero == "OCHO" || numero == "ocho")
                {
                    Console.WriteLine("Numero: 8");
                }
                if (numero == "Nueve" || numero == "NUEVE" || numero == "nueve")
                {
                    Console.WriteLine("Numero: 9");
                }
                if (numero == "Diez" || numero == "DIEZ" || numero == "diez")
                {
                    Console.WriteLine("Numero: 10");
                }
            }
        }
    }
}
    

