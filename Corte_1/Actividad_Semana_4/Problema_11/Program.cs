using System;

namespace Problema_11
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
        /*Crea un programa que pida por pantalla cuatro países y a continuación tres ciudades de cada uno de estos países.
         * Los nombres de ciudades deben almacenarse en un array multidimensional cuyo primer índice sea el número asignado a cada país
         * y el segundo índice el número asignado a cada ciudad.
         **/
        static void Main(string[] args)
        {
            string primerPais, segundoPais, tercerPais, cuartoPais;
            Console.WriteLine("Digite el primer pais");
            primerPais = Console.ReadLine();
            Console.WriteLine("Digite el segundo pais");
            segundoPais = Console.ReadLine(); 
            Console.WriteLine("Digite el tercer pais");
            tercerPais = Console.ReadLine();
            Console.WriteLine("Digite el cuarto pais");
            cuartoPais = Console.ReadLine();

            string[,] arrayCiudades = new string[4, 3];
            Console.WriteLine($"Digite la primera ciudad de {primerPais}");
            arrayCiudades[0, 0] = Console.ReadLine();
            Console.WriteLine($"Digite la segunda ciudad de {primerPais}");
            arrayCiudades[0, 1] = Console.ReadLine();
            Console.WriteLine($"Digite la tercera ciudad de {primerPais}");
            arrayCiudades[0, 2] = Console.ReadLine();

            Console.WriteLine($"Digite la primera ciudad de {segundoPais}");
            arrayCiudades[1, 0] = Console.ReadLine();
            Console.WriteLine($"Digite la segunda ciudad de {segundoPais}");
            arrayCiudades[1, 1] = Console.ReadLine();
            Console.WriteLine($"Digite la tercera ciudad de {segundoPais}");
            arrayCiudades[1, 2] = Console.ReadLine(); 

            Console.WriteLine($"Digite la primera ciudad de {tercerPais}");
            arrayCiudades[2, 0] = Console.ReadLine();
            Console.WriteLine($"Digite la segunda ciudad de {tercerPais}");
            arrayCiudades[2, 1] = Console.ReadLine();
            Console.WriteLine($"Digite la tercera ciudad de {tercerPais}");
            arrayCiudades[2, 2] = Console.ReadLine();

            Console.WriteLine($"Digite la primera ciudad de {cuartoPais}");
            arrayCiudades[3, 0] = Console.ReadLine();
            Console.WriteLine($"Digite la primera ciudad de {cuartoPais}");
            arrayCiudades[3, 1] = Console.ReadLine();
            Console.WriteLine($"Digite la primera ciudad de {cuartoPais}");
            arrayCiudades[3, 2] = Console.ReadLine();

            Console.WriteLine($@"
            Pais: {primerPais}          Ciudades {arrayCiudades[0,0]} {arrayCiudades[0,1]} {arrayCiudades[0,2]}\n
            Pais: {segundoPais}         Ciudades: {arrayCiudades[1,0]} {arrayCiudades[1,1]} {arrayCiudades[1,2]}\n
            Pais: {tercerPais}          Ciudades: {arrayCiudades[2,0]} {arrayCiudades[2,1]} {arrayCiudades[2,2]}\n
            Pais: {cuartoPais}          Ciudades: {arrayCiudades[3,0]} {arrayCiudades[3,1]} {arrayCiudades[3,2]}\n
            ");
        }
    }
}
