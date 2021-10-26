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

namespace Ejemplotostring
{

    class Estudiante
    {
        private string Nombre;
        public double calificacion;

        public string DameNombre
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return Nombre;
            }
        }
        public double DameCalificacion
        {
            set
            {
                calificacion = value;
            }
            get
            {
                return calificacion;
            }
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + "\n" + "Calificacion" + calificacion;
        }
    }
}