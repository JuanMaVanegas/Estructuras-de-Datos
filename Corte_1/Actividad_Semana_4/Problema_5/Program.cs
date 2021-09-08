using System;

namespace Problema6
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
                63102C / 239 - 2A*/ 
            // Problema 5: Crea un array de caracteres que contenga de la ‘A’ a la ‘Z’ (solo las mayúsculas).
            // Después, ve pidiendo posiciones del array por teclado
             int N = 0;

                    char[] Abecedario;
                    Abecedario = new char[27];

                    Abecedario[0] = 'A';
                    Abecedario[1] = 'B';
                    Abecedario[2] = 'C';
                    Abecedario[3] = 'D';
                    Abecedario[4] = 'E';
                    Abecedario[5] = 'F';
                    Abecedario[6] = 'G';
                    Abecedario[7] = 'H';
                    Abecedario[8] = 'I';
                    Abecedario[9] = 'J';
                    Abecedario[10] = 'K';
                    Abecedario[11] = 'L';
                    Abecedario[12] = 'M';
                    Abecedario[13] = 'N';
                    Abecedario[14] = 'Ñ';
                    Abecedario[15] = 'O';
                    Abecedario[16] = 'P';
                    Abecedario[17] = 'Q';
                    Abecedario[18] = 'R';
                    Abecedario[19] = 'S';
                    Abecedario[20] = 'T';
                    Abecedario[21] = 'U';
                    Abecedario[22] = 'V';
                    Abecedario[23] = 'W';
                    Abecedario[24] = 'X';
                    Abecedario[25] = 'Y';
                    Abecedario[26] = 'Z';
            do
            { 
              Console.WriteLine("Por favor ingrese un numero para asi mostrar la letra correspondiente. (-4 PARA SALIR)");
              N = Convert.ToInt32(Console.ReadLine());
                if (N <= 26)
                {
                    Console.WriteLine("Su letra del abecedario es: "+ Abecedario[N]);
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un numero del 0 al 26");
                }
                
            } while (N != -4 );
        }
    }
}
