using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int DiasFI, MesFI, AñoFI;
            int DiasFT, MesFT, AñoFT;

            Console.WriteLine("Calculador de tiempo ");
            Console.WriteLine("Por favor escriba el tiempo actual: ");
            Console.WriteLine("Escriba el día actual: ");
            DiasFI = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el mes actual: ");
            MesFI = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el año acual: ");
            AñoFI = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el tiempo anterior que desea calcular: ");
            Console.WriteLine("Escriba el día: ");
            DiasFT = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el mes: ");
            MesFT = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el año: ");
            AñoFT = int.Parse(Console.ReadLine());

            int AntDias = 0, AntMeses = 0, AntAños = 0;

            if (DiasFT < DiasFI)
            {
                DiasFT += 30;
                MesFT -= 1;
            }
            AntDias = DiasFT - DiasFI;

            if (MesFT < MesFI)
            {
                MesFT += 12;
                AñoFT -= 1;
            }
            AntMeses = MesFT - MesFI;

            AntAños = (AñoFT - AñoFI) * -1;

            Console.WriteLine("Antiguedad: Días: {0}, Meses: {1}, Años: {2}", AntDias, AntMeses, AntAños);
            Console.ReadKey();
        }
    }
}
