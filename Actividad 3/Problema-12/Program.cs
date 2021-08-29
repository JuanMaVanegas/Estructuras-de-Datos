using System;

namespace Problema_12
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
                63102C / 239 - 2A */
                
            int cand_1=0,cand_2=0,cand_3=0,cant,opc;

            Console.WriteLine("Ingrese el nombre de los candidatos: ");
            string nom1=Console.ReadLine();
            string nom2=Console.ReadLine();
            string nom3=Console.ReadLine();
            
            Console.WriteLine("Digite la cantidad de estudiantes a votar: ");
            cant = int.Parse(Console.ReadLine());
            while (true){

        
            if (cant<20){
                Console.WriteLine("La cantidad minima de estudiantes es 20");
                cant = int.Parse(Console.ReadLine());
            }
            else if (cant>=20){
                for(int i =0; i < cant; i++ ){
                Console.WriteLine($"\nPor favor eliga a un candidato: \nCandidato 1. {nom1}\nCandidato 2. {nom2}\nCandidato 3. {nom3}");
                opc = int.Parse(Console.ReadLine());

                switch (opc){
                    case 1:
                    cand_1++;
                    continue;

                    case 2:
                    cand_2++;
                    continue;

                    case 3:
                    cand_3++;
                    continue;
                }
                if (opc < 1 || opc > 3){
                    Console.WriteLine("\nIngrese una opción valida");
                    i--;
                }
            }
                
            
                if(cand_1 > cand_2 && cand_1 > cand_3){
                    Console.WriteLine($"\nEl candidato ganador es {nom1} con {cand_1} votos.\nSerá el nuevo representante estudiantil");
                }
                else if(cand_2 > cand_3 && cand_2 > cand_1){
                    Console.WriteLine($"\nEl candidato ganador es {nom2} con {cand_2} votos.\nSerá el nuevo representante estudiantil");
                }
                else if(cand_3 > cand_2 && cand_3 > cand_1){
                    Console.WriteLine($"\nEl candidato ganador es {nom3} con {cand_3} votos.\nSerá el nuevo representante estudiantil");
                }
                break;
            }
            }
        }
    }
}
