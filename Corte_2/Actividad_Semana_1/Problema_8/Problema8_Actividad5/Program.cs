using System;
using System.Linq;

namespace Problema8_Actividad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double precioProducto1, precioProducto2, precioProducto3, precioProducto4, precioProducto5;
            double cantidadSucursal1, cantidadSucursal2, cantidadSucursal3, cantidadSucursal4;
            double totalVendido, totalArticulos;
            double totalSucursal1, totalSucursal2, totalSucursal3, totalSucursal4;
            double[,] productoSucursal = new double[5, 4];

            Console.WriteLine("-------------------------PRIMER PRODUCTO-------------------------------");
            Console.WriteLine("Digite el precio del primer producto: ");
            precioProducto1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 1:");
            productoSucursal[0,0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 2:");
            productoSucursal[0,1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 3:");
            productoSucursal[0, 2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 4:");
            productoSucursal[0, 3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("-------------------------SEGUNDO PRODUCTO-------------------------------");
            Console.WriteLine("Digite el precio del segundo producto: ");
            precioProducto2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 1:");
            productoSucursal[1, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 2:");
            productoSucursal[1, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 3:");
            productoSucursal[1, 2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 4:");
            productoSucursal[1, 3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("-------------------------TERCER PRODUCTO--------------------------------");
            Console.WriteLine("Digite el precio del tercer producto: ");
            precioProducto3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 1:");
            productoSucursal[2, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 2:");
            productoSucursal[2, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 3:");
            productoSucursal[2, 2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 4:");
            productoSucursal[2, 3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("-------------------------CUARTO PRODUCTO-------------------------------");
            Console.WriteLine("Digite el precio del cuarto producto: ");
            precioProducto4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 1:");
            productoSucursal[3, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 2:"); 
            productoSucursal[3, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 3:");
            productoSucursal[3, 2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 4:");
            productoSucursal[3, 3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("-------------------------QUINTO PRODUCTO-------------------------------");
            Console.WriteLine("Digite el precio del quinto producto: ");
            precioProducto5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 1:");
            productoSucursal[4, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 2:");
            productoSucursal[4, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 3:");
            productoSucursal[4, 2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite cantidades vendidas en la sucursal 4:");
            productoSucursal[4, 3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("---------------------------------INFORME----------------------------------");
            cantidadSucursal1 = productoSucursal[0, 0] + productoSucursal[1, 0] + productoSucursal[2, 0] + productoSucursal[3, 0] + productoSucursal[4, 0];
            totalSucursal1 = (productoSucursal[0, 0] * precioProducto1) + (productoSucursal[1,0] * precioProducto2) + (productoSucursal[2, 0] * precioProducto3) + (productoSucursal[3, 0] * precioProducto4) + (productoSucursal[4, 0] * precioProducto5);
            Console.WriteLine($"\nEl total de productos vendidos en la sucursal 1 fue: {cantidadSucursal1}, dando un total monetario de {totalSucursal1}");

            cantidadSucursal2 = productoSucursal[0, 1] + productoSucursal[1, 1] + productoSucursal[2, 1] + productoSucursal[3, 1] + productoSucursal[4, 1];
            totalSucursal2 = (productoSucursal[0, 1] * precioProducto1) + (productoSucursal[1, 1] * precioProducto2) + (productoSucursal[2, 1] * precioProducto3) + (productoSucursal[3, 1] * precioProducto4) + (productoSucursal[4, 1] * precioProducto5);
            Console.WriteLine($"\nEl total de productos vendidos en la sucursal 2 fue: {cantidadSucursal2}, dando un total monetario de {totalSucursal2}");

            cantidadSucursal3 = productoSucursal[0, 2] + productoSucursal[1, 2] + productoSucursal[2, 2] + productoSucursal[3, 2] + productoSucursal[4, 2];
            totalSucursal3 = (productoSucursal[0, 2] * precioProducto1) + (productoSucursal[1, 2] * precioProducto2) + (productoSucursal[2, 2] * precioProducto3) + (productoSucursal[3, 2] * precioProducto4) + (productoSucursal[4, 2] * precioProducto5);
            Console.WriteLine($"\nEl total de productos vendidos en la sucursal 3 fue: {cantidadSucursal3}, dando un total monetario de {totalSucursal3}");

            cantidadSucursal4 = productoSucursal[0, 3] + productoSucursal[1, 3] + productoSucursal[2, 3] + productoSucursal[3, 3] + productoSucursal[4, 3];
            totalSucursal4 = (productoSucursal[0, 3] * precioProducto1) + (productoSucursal[1, 3] * precioProducto2) + (productoSucursal[2, 3] * precioProducto3) + (productoSucursal[3, 3] * precioProducto4) + (productoSucursal[4, 3] * precioProducto5);
            Console.WriteLine($"\nEl total de productos vendidos en la sucursal 4 fue: {cantidadSucursal4}, dando un total monetario de {totalSucursal4}");

            totalArticulos = cantidadSucursal1 + cantidadSucursal2 + cantidadSucursal3 + cantidadSucursal4;
            Console.WriteLine($"\nLa cantidad total de productos vendidos fue de {totalArticulos}");

            Console.WriteLine($"\nLa sucursal 2 vendio {cantidadSucursal2} articulos");

            Console.WriteLine($"\nHay {productoSucursal[2, 0]} articulos del tercer producto en la sucursal 1");

            totalVendido = totalSucursal1 + totalSucursal2 + totalSucursal3 + totalSucursal4;
            Console.WriteLine($"\nHubo una una recaudacion total de la empresa de {totalVendido}");

            double[] saberMayor = { totalSucursal1 , totalSucursal2, totalSucursal2, totalSucursal3,totalSucursal4};

            if (saberMayor.Max() == totalSucursal1)
            {
                Console.WriteLine("\nLa sucursal de mayor recaudacion fue la sucursal 1");
            }
            if(saberMayor.Max() == totalSucursal2)
            {
                Console.WriteLine("\nLa sucursal de mayor recaudacion fue la sucursal 2");
            }
            if(saberMayor.Max() == totalSucursal3)
            {
                Console.WriteLine("\nLa sucursal de mayor recaudacion fue la sucursal 3");
            }
            if(saberMayor.Max() == totalSucursal4)
            {
                Console.WriteLine("\nLa sucursal de mayor recaudacion fue la sucursal 4");
            }
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
