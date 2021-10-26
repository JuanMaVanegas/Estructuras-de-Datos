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

namespace Ejercicio_xtrazo
{

    /*Cuantos dias hay entre dos fechas predeterminadas.*/

    class ejer_DateTime
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2014, 10, 23);
            DateTime fechaConHora = new DateTime(2005, 4, 23, 9, 30, 45);

            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd-MM-yy"));
            Console.WriteLine(fechaConHora.ToString("dd*MM*yy hh:mm:ss"));
            Console.WriteLine(fecha.AddDays(45).ToString());

            Console.WriteLine(fechaConHora.DayOfWeek);
            Console.WriteLine(fechaConHora.Date);

            Console.WriteLine(fecha.Subtract(fechaConHora).Days);
            Console.Read();

        }
    }
}