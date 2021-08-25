using System;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
        /*INTEGRANTES DEL GRUPO:
            Johan Sebastian Rios
            Luis Esteban Triana
            Juan Manuel Vanegas
            Adres Santiago Villamil 
        Jornada:
            Diurna
        Grupo:
            63102C / 239-2A */ 
            
            string frase=" ";

            Console.WriteLine("Por favor ingrese la frase: ");
            frase = Console.ReadLine();
            
            int digitos=0,letras=0,vocales=0;
            
            for (int i = 0; i < frase.Length; i++) {
                char c=char.Parse(frase.Substring(i, 1));
                string d=(Char.ToString(c));
                if (d=="a" || d=="e" || d=="i" || d=="o" || d=="u" || d=="A" || d=="E" || d=="I" || d=="O" || d=="U"){
                    vocales++;
                }
                else if (char.IsDigit(c)){
                    digitos++;
                }
                else if(char.IsLetter(c)){
                    letras++;
                }
                else{
                    continue;
                }
            }
            Console.WriteLine("Cantidad de vocales: "+vocales);
            Console.WriteLine("Cantidad de digitos: "+digitos);
            Console.WriteLine("Cantidad de letras: "+letras);
            
        }
    }
}
