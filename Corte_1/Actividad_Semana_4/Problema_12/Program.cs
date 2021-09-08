using System;

namespace Problema_12
{
    class Program
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
        static void Main(string[] args)
        {
            string[] meses = new string[12];
            string[] dias = new string[365];
            string[] hora = new string[24];
            string[] evento = new string[365];

            int numEventos;
            string even;

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------2021----------------------------------------------------------------");
            Console.WriteLine("(calendario ficticio)");
            Console.WriteLine("");
            Console.WriteLine(@"
            Enero                                        Febrero                                    Marzo
Lun Mart Mier Juev Vier Sab Dom              Lun Mart Mier Juev Vier Sab Dom            Lun Mart Mier Juev Vier Sab Dom 
 1   2    3    4    5    6   7                              1    2    3   4                                          1
 8   9    10   11   12   13  14               5   6    7    8    9    10  11             2    3   4    5    6    7   8
15   16   17   18   19   20  21               12  13   14   15   16   17  18             9    10  11   12   13   14  15
22   23   24   25   26   27  28               19  20   21   22   23   24  25             16   17  18   19   20   21  22
29   30   31                                  26  27   28   29   30   31                 23   24  25   26   27   28  29
                                                                                         30   31
            Abril                                          Mayo                                      Junio
Lun Mart Mier Juev Vier Sab Dom              Lun Mart Mier Juev Vier Sab Dom            Lun Mart Mier Juev Vier Sab Dom 
          1    2    3    4    5                                           1                       1    2    3    4   5
 6   7    8    9    10   11  12               2   3    4    5    6    7   8              6    7   8    9    10   11  12
13   14   15   16   17   18  19               9   10   11   12   13   14  15             13   14  15   16   17   18  19
20   21   22   23   24   25  26               16  17   18   19   20   21  22             20   21  22   23   24   25  26
27   28   28   29   30   31                   23  24   25   26   27   28  29             27   28  29   30   31   
                                              30  31                                     
            Julio                                          Agosto                                    Septiembre
Lun Mart Mier Juev Vier Sab Dom              Lun Mart Mier Juev Vier Sab Dom            Lun Mart Mier Juev Vier Sab Dom 
                         1   2                    1    2    3    4    5   6                                 1    2   3
 3   4    5    6    7    8   9                7   8    9    10   11   12  13             5    6   7    8    9    10  11
10   11   12   13   14   15  16               14  15   16   17   18   19  20             12   13  14   15   16   17  18
17   18   19   20   21   22  23               21  22   23   24   25   26  27             19   20  21   22   23   24  25
24   25   26   27   28   29  30               28  29   30   31                           26   27  28   29   30   31
31                           

            Octubre                                        Noviembre                                   Diciembre
Lun Mart Mier Juev Vier Sab Dom              Lun Mart Mier Juev Vier Sab Dom            Lun Mart Mier Juev Vier Sab Dom 
                             1                         1    2    3    4   5                                      1   2
 2   3    4    5    6    7   8                6   7    8    9    10   11  12             3    4   5    6    7    8   9
 9   10   11   12   13   14  15               13  14   15   16   17   18  19             10   11  12   13   14   15  16
16   17   18   19   20   21  22               20  21   22   23   24   25  26             17   18  19   20   21   22  23
23   24   25   26   27   28  29               27  28   29   30   31                      24   25  26   27   28   29  30
30   31                                                                                  31


");
                Console.WriteLine("Desea guardar un evento? Si/No");
                even = Console.ReadLine();
                if (even == "Si" || even == "si")
                {
                    try
                    {
                        Console.WriteLine("Cuantos eventos desea guardar?");
                        numEventos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(@"

");
                        for (int f = 0; f < numEventos; f++)
                         {
                            Console.WriteLine("Que mes sera el evento?");
                            meses[f] = Console.ReadLine();
                            Console.WriteLine("Que dia sera el evento?");
                            dias[f] = Console.ReadLine();
                            Console.WriteLine("A que horas sera el evento?");
                            hora[f] = Console.ReadLine();

                            evento[f] = $"Tiene un evento el mes de {meses[f]} el dia {dias[f]} a las {hora[f]}";
                         }
                        Console.WriteLine(@"

");
                        Console.WriteLine("Eventos:");
                        for (int a = 0; a < numEventos; a++)
                        {
                            Console.WriteLine(evento[a]);
                            Console.WriteLine("");
                        } 
                    }
                    catch
                    {
                        Console.WriteLine("Debe digitar numeros");
                    }
                }
            Console.WriteLine("");
                Console.WriteLine("Muchas gracias, vuelva pronto");
            Console.WriteLine("Att: Santiago Villamil");
            Console.ReadKey();
        }
    }
}
