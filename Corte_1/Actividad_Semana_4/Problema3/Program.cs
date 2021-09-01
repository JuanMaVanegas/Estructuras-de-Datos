using System;

namespace Problema3
{
    class Program
    {
        /*INTEGRANTES DEL GRUPO:
                Johan Sebastian Rios
                Luis Esteban Triana
                Juan Manuel Vanegas
                Andres Santiago Villamil 
            Jornada:
                Diurna
            Grupo:
                63102C / 239 - 2A */
                
        private static void RellenarAletPrimos(int [] ranNum){
            Random numAleatorio = new Random();
            int i=0;
            while(i < ranNum.Length){           
                int primo = numAleatorio.Next(0,1000);           
                if (NumPrimo(primo)){              
                    ranNum[i]=primo;               
                    i++;            
                }       
            }   
        } 
        private static bool NumPrimo (int primo){      

            if (primo<=1){
                return false;
            }else{
                for (int i = 2; i < primo; i++){
                    if((primo % i) == 0)
                    {
                        return false;
                    }
            }
            return true;
            }   
        }
        private static void MostrarNumeros(int [] ranNum){
            for (int i = 0; i < ranNum.Length; i++)
            {
                Console.WriteLine($" -> El valor de la posición {i} del Array es {ranNum[i]}");
            }

        }
        private static void MayorPrimo(int [] ranNum){
            int mayor=0;
            for(int i=0;i<ranNum.Length;i++){
                if(ranNum[i]>mayor){
                    mayor=ranNum[i];
                }
            }
            Console.WriteLine($"\nEl numero primo mayor es: {mayor}");;
        }
        private static void MenorPrimo(int [] ranNum){
            int menor=1000;
            for(int i=0;i<ranNum.Length;i++){
                if(ranNum[i]<menor){
                    menor=ranNum[i];
                }
            }
            Console.WriteLine($"El numero primo menor es: {menor}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del array: ");
            int longV = int.Parse(Console.ReadLine());
            int [] num = new int [longV];

            RellenarAletPrimos(num);
            MostrarNumeros(num);
            MayorPrimo(num);
            MenorPrimo(num);

        }
    }
}
