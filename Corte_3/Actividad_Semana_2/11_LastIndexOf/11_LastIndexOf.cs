using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* INTEGRANTES DEL GRUPO:
               Johan Sebastián Ríos
               Luis Esteban Triana
               Juan Manuel Vanegas
               Andrés Santiago Villamil 
           Jornada:
               Diurna
           Grupo:
               63102C / 239 - 2A*/

namespace Ejercicio_x_trazo
{

    class Indexof
    {
        static void Main(string[] args)
        {
            string ejemplo = "Hola bienvenidos a programando en c#";
            int tam = ejemplo.Length;
            string subcad = "venidos";
            if (ejemplo.Contains(subcad))
                Console.WriteLine("{0} se encuentra en la frase: {1}", subcad, ejemplo);
                Console.WriteLine("bien se encuentra en la posicion {0}",ejemplo.IndexOf("bien"));
                Console.WriteLine("do se encuentra por ultima vez en la posicion {0}",ejemplo.LastIndexOf("do"));
                Console.WriteLine("Mayuscula : {0}",ejemplo.ToUpper());
                Console.WriteLine("Minuscula : {0}", ejemplo.ToLower());
                Console.WriteLine("Hemos insertado amigo a la frase: {0}", ejemplo.Insert(5, "amigos "));
                Console.WriteLine("Hemos removido el inicio de la frase: {0}", ejemplo.Remove(0, 5));
                Console.WriteLine("Hemos reemplazado \"hola\"por\"que tal\"", ejemplo.Replace("Hola", "Que tal"));

            Console.ReadKey();        
        }
    }
}