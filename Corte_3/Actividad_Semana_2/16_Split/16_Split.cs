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

    class Split
    {
        static void Main(string[] args)
        {
            string cadena = "Hola, bienvenidos, mis, amigos.";
            char delimitador = ',';
            string [ ] valores = cadena.Split(delimitador);
            
          
                Console.WriteLine(valores[3]);
               
            Console.ReadKey();        
        }
    }
}