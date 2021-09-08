using System;

namespace Problema7
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
                63102C / 239-2A */
        static void Main(string[] args)
        {
            String [] Nom = new string [12];
            double [] Not = new double [12];
            String [] Resul = new string [12];
            NomEst(Nom);
            NotEst(Not);
            ResulEst(Nom,Not,Resul);
        }
        public static void NomEst (String[]Nom)
        {
            for(int i=0;i<12;i++)
            {
                Console.WriteLine("Ingrese nombre del estudiante {0}",i+1);
                Nom[i]= Console.ReadLine();
            }
        }
        public static void NotEst (double[]Not)
        {
            for(int i=0;i<12;i++)
            {   Console.WriteLine("Los decimales deben ser de la siguiente forma");
                Console.WriteLine("x,y");
                do
                {
                    Console.WriteLine("Ingrese nota del estudiante {0}",i+1);
                    Not[i]= Convert.ToDouble(Console.ReadLine());
                }while(Not[i] <=0 && Not[i] >=10);
            }   
            
        }
        public static void ResulEst (String[]Nom, double[]Not , String[]Resul)
        {
            int j=0;
            string [] Resultado = {"insuficiente", "aceptable", "sobresaliente","excelente"};
            for(int i=0;i<12;i++)
            {
                if(Not[i]>=0 && Not[i]<=4.99)
                {
                    j=0;
                }
                if(Not[i]>=5 && Not[i]<=6.99)
                {
                    j=1;
                }
                if(Not[i]>=7 && Not[i]<=9.99)
                {
                    j=2;
                }
                if(Not[i]>=9 && Not[i]<=10)
                {
                    j=3;
                }
                Console.WriteLine("El estudiante {0} tiene una nota de {1}, su valoracion es {2}",Nom[i],Not[i],Resultado[j]);
            }
        }
    }
}
