using System;

namespace Problema_10
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
    class Program
    {
        /*Queremos almacenar en una matriz el número de alumnos con el que cuenta una academia, ordenados en función del nivel y del idioma 
         * que se estudia. Tendremos 3 filas que representarán al Nivel básico, medio y de perfeccionamiento y 4 columnas en las que 
         * figurarán los idiomas (0 = Inglés, 1 = Francés, 2 = Alemán y 3 = Ruso). Se pide realizar la declaración de la matriz y asignarle 
         * unos valores de ejemplo a cada elemento.*/
        static void Main(string[] args)
        {
            string[,] alumnos = new string[3, 4];
            Console.WriteLine("");

            alumnos[0, 0] = "Esteban";
            alumnos[0, 1] = "Maria";
            alumnos[0, 2] = "Miguel";
            alumnos[0, 3] = "Juan";
            alumnos[1, 0] = "Andres";
            alumnos[1, 1] = "Luis";
            alumnos[1, 2] = "Nicolas";
            alumnos[1, 3] = "Sofia";
            alumnos[2, 0] = "Julian";
            alumnos[2, 1] = "Jose";
            alumnos[2, 2] = "Laura";
            alumnos[2, 3] = "Ana";

            Console.Write($@"                   
                                              0      1      2     3
                            Nivel basico:  {alumnos[0,0]} {alumnos[0,1]} {alumnos[0,2]}  {alumnos[0,3]}
                            Nivel medio:   {alumnos[1,0]}  {alumnos[1,1]}  {alumnos[1,2]} {alumnos[1,3]}
                            Perfeccionar:  {alumnos[2,0]}  {alumnos[2,1]}  {alumnos[2,2]}   {alumnos[2,3]}");
            Console.ReadKey();
        }
    }
}
