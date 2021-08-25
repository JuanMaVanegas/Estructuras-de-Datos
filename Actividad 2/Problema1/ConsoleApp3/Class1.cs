using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 1.Crear un programa que pida una calificación de 0 a 100 para las materias de Matemáticas, español, inglés y Física 
/// para 5 estudiantes que se registren al iniciar el programa los resultados deberán mostrar la información de la siguiente manera:
/// Insuficiente (Menor a 50)Suficiente (De 50 a 69)Bien (De 60 a 79)Notable (De 70 a 89)Sobresaliente (De 90 a 100)
/// en cada estudiante y materia.
   /// INTEGRANTES DEL GRUPO:
//Johan Sebastian Rios
 // Luis Esteban Triana
 // Juan Manuel Vanegas
 // Andres Santiago Villamil 
 //Jornada:
 // Diurna
 //Grupo:
 //63102C / 239 - 2A */
namespace calificacionesxtrazo
{
    class Program
    {
       struct datos
        {
            public string nombre;
            public string apellido;
            public double nota1;
            public double nota2;
            public double nota3;
            public double nota4;          
        } 
        static void Main(string[]args)
        {
            datos[] estudiante = new datos[5];
            for(int i = 0; i <= 4; i++)
            {
                Console.Write("Nombre del estudiante: ");
                estudiante[i].nombre = Console.ReadLine();
                Console.Write("Apellido del estudiante: ");
                estudiante[i].apellido = Console.ReadLine();

                Console.Write("ingles :");
                estudiante[i].nota1 = double.Parse(Console.ReadLine());
                    if (estudiante[i].nota1 <= 49)
                    {
                        Console.WriteLine("insuficiente");
                    }
                    else
                       if (estudiante[i].nota1 > 50 && estudiante[i].nota1 < 69)
                    {
                        Console.WriteLine("suficiente");
                    }
                    else
                           if (estudiante[i].nota1 > 70 && estudiante[i].nota1 < 79)
                    {
                        Console.WriteLine("bien");
                    }
                    else
                               if (estudiante[i].nota1 > 80 && estudiante[i].nota1 < 89)
                    {
                        Console.WriteLine("notable");
                    }
                    else
                                     if (estudiante[i].nota1 > 90 || estudiante[i].nota1 < 100)
                    {
                        Console.WriteLine("sobresaliente");
                    }
                Console.Write("matematicas :");
                estudiante[i].nota2 = double.Parse(Console.ReadLine());
                    if (estudiante[i].nota1 <= 49)
                    {
                        Console.WriteLine("insuficiente");
                    }
                    else
                          if (estudiante[i].nota1 > 50 && estudiante[i].nota1 < 69)
                    {
                        Console.WriteLine("suficiente");
                    }
                    else
                              if (estudiante[i].nota1 > 70 && estudiante[i].nota1 < 79)
                    {
                        Console.WriteLine("bien");
                    }
                    else
                                  if (estudiante[i].nota1 > 80 && estudiante[i].nota1 < 89)
                    {
                        Console.WriteLine("notable");
                    }
                    else
                                        if (estudiante[i].nota1 > 90 && estudiante[i].nota1 < 100)
                    {
                        Console.WriteLine("sobresaliente");
                    }
                Console.Write("fisica :");
                estudiante[i].nota3 = double.Parse(Console.ReadLine());
                    if (estudiante[i].nota1 <= 49)
                    {
                        Console.WriteLine("insuficiente");
                    }
                    else
                          if (estudiante[i].nota1 > 50 && estudiante[i].nota1 < 69)
                    {
                        Console.WriteLine("suficiente");
                    }
                    else
                              if (estudiante[i].nota1 > 70 && estudiante[i].nota1 < 79)
                    {
                        Console.WriteLine("bien");
                    }
                    else
                                  if (estudiante[i].nota1 > 80 && estudiante[i].nota1 < 89)
                    {
                        Console.WriteLine("notable");
                    }
                    else
                                        if (estudiante[i].nota1 > 90 && estudiante[i].nota1 < 100)
                    {
                        Console.WriteLine("sobresaliente");
                    }
                Console.Write("español :");
                estudiante[i].nota4 = double.Parse(Console.ReadLine());
                    if (estudiante[i].nota1 <= 49)
                    {
                        Console.WriteLine("insuficiente");
                    }
                    else
                          if (estudiante[i].nota1 > 50 && estudiante[i].nota1 < 69)
                    {
                        Console.WriteLine("suficiente");
                    }
                    else
                              if (estudiante[i].nota1 > 70 && estudiante[i].nota1 < 79)
                    {
                        Console.WriteLine("bien");
                    }
                    else
                                  if (estudiante[i].nota1 > 80 && estudiante[i].nota1 < 89)
                    {
                        Console.WriteLine("notable");
                    }
                    else
                                        if (estudiante[i].nota1 > 90 && estudiante[i].nota1 < 100)
                    {
                        Console.WriteLine("sobresaliente");
                    }
            }
            Console.WriteLine("*************/////////**************");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Nombre:" + estudiante[i].nombre);
                Console.WriteLine("apellido:" + estudiante[i].apellido);
                Console.WriteLine("ingles:" + estudiante[i].nota1);
                Console.WriteLine("matematicas:" + estudiante[i].nota2);
                Console.WriteLine("fisica:" + estudiante[i].nota3);
                Console.WriteLine("español:" + estudiante[i].nota4);
                Console.WriteLine("****************************");
            }
        }

    }
    
}

    

