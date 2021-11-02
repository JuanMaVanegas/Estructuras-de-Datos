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

    class Ejercicio_____HOY
     {
        class club
        {
            private string socios;
            private int antiguedad;

            public club()
            {
                Console.Write("Ingrese el nombre del miembre del club:");
                socios = Console.ReadLine(); ;
                Console.Write("Ingrese la antiguedad en años:");
                string linea = Console.ReadLine();
                antiguedad = int.Parse(linea);
            }

            public void Imprimir()
            {
                Console.WriteLine( "-->"+socios + "-Ya que tiene una antiguedad de " + antiguedad +" años ");
            }

            public int RetornarAntiguedad()
            {
                return antiguedad;
            }
        }


        class Club
        {
            private club socio1, socio2, socio3;

            public Club()
            {
                socio1 = new club();
                socio2 = new club();
                socio3 = new club();
            }

            public void MayorAntiguedad()
            {
                Console.Write("El miembro del club con mayor antiguedad es:");
                if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() &&
                    socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    socio1.Imprimir();
                }
                else
                {
                    if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                    {
                        socio2.Imprimir();
                    }
                    else
                    {
                        socio3.Imprimir();
                    }
                }

            }

            static void Main(string[] args)
            {
                Club club1 = new Club();
                club1.MayorAntiguedad();
                Console.WriteLine("Gracias por usar el programa vuelva pronto :)");
                Console.WriteLine("Creado por: Luis Esteban Triana ");
                Console.ReadKey();
            }
        }
    }
}