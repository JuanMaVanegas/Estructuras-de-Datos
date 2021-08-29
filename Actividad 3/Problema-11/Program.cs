using System;

namespace Problema_11
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
            string nombre;
            decimal sueldo,suma_sm=0.0m,suma_sf=0.0m;
            int genero,cant,contf=0,contm=0,legajo;
            
            Console.WriteLine("Ingrese la cantidad de empleados: ");
            cant = int.Parse(Console.ReadLine());

            for (int i=0; i < cant; i ++){
                Console.WriteLine($"\nPor favor digite el nombre del empleado {i+1}: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número de legajo");
                legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sueldo del empleado: ");
                sueldo = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el genero (1=M 2=F): ");
                genero = int.Parse(Console.ReadLine());

                if (genero==1){
                    suma_sm = sueldo + suma_sm;
                    if (sueldo < 900000.0m){
                        contm++;
                    }
                }
                if (genero==2){
                    suma_sf = sueldo + suma_sf;
                    if (sueldo > 1000000.0m){
                        contf++;
                    }
                }
            }
            Console.WriteLine($"\nCantidad de hombres que ganan menos de $900000: {contm}");
            Console.WriteLine($"Cantidad de mujeres que ganan más de $1000000: {contf}");
            Console.WriteLine($"\nCantidad de dinero para los hombres: {suma_sm}");
            Console.WriteLine($"Cantidad de dinero para las mujeres: {suma_sf}");

            
        }
    }
}
