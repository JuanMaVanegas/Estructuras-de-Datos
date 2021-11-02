using System;

namespace Problema1
{
    class Empleado
    {
        /* INTEGRANTES DEL GRUPO:
               Johan Sebastián Ríos
               Luis Esteban Triana
               Juan Manuel Vanegas
               Andrés Santiago Villamil 
           Jornada:
               Diurna
           Grupo:
               63102C / 239 - 2A*/

        /*Confeccionar una clase que represente un empleado. Definir como atributos 
        su nombre y su sueldo. En el constructor cargar los atributos y luego en otro 
        método imprimir sus datos y por último uno que imprima un mensaje si debe 
        pagar impuestos (si el sueldo supera a 3000)*/

        private double Salario;
        private string Nombre;

        private Empleado(){
            Console.WriteLine("\nPor favor digite su nombre completo: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("A continuación digite su salario: ");
            Salario = double.Parse(Console.ReadLine());
        }

        private void ImprimirDatos(){
            Console.WriteLine("\nNombre del empleado:\t{0}",Nombre);
            Console.WriteLine("Salario del empleado:\t${0}",Salario);
        }

        private void PagarImpuestos(){
            if (Salario > 3000){
                Console.WriteLine("Debes pagar impuestos, su salario supero los $3000");
            }
            else{
                Console.WriteLine("No debes pagar impuestos, su salario no supera los $3000");
            }
            
        }

        static void Main(string[] args)
        {
            Empleado sb = new Empleado();
            sb.ImprimirDatos();
            sb.PagarImpuestos();
            Console.WriteLine("");
        }
    }
}
