using System;

namespace Problema8
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

            int mes;
            Console.WriteLine("Por favor ingrese el número del mes: ");
            mes = int.Parse(Console.ReadLine());

            if(mes < 1 || mes > 12)                                
            Console.WriteLine("El mes que ingresaste es incorrecto");
            else{ 
                switch(mes){                                  
                    case 1: Console.Write("Enero");
                            break;
                    case 2: Console.Write("Febrero");
                            break;
                    case 3: Console.Write("Marzo");
                            break;
                    case 4: Console.Write("Abril");
                            break;
                    case 5: Console.Write("Mayo");
                            break;
                    case 6: Console.Write("Junio");
                            break;
                    case 7: Console.Write("Julio");
                            break;
                    case 8: Console.Write("Agosto");
                            break;
                    case 9: Console.Write("Septiembre");
                            break;
                    case 10: Console.Write("Octubre");
                            break;
                    case 11: Console.Write("Noviembre");
                            break;
                    case 12: Console.Write("Diciembre");
                            break;
            }
            if(mes == 4 || mes == 6 || mes == 9 || mes == 11)       
               Console.Write(", y este mes tiene 30 dias");
            else if(mes == 2)
                     Console.Write(", y este mes tiene 28 dias");
                   else
                      Console.Write(", y este mes tiene 31 dias");
        }
        }
    }
}
