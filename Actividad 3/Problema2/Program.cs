using System;

namespace Problema2
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
                
            // Problema 2:Crear un programa, que dado un número, compruebe si es adecuado para montar pilas triangulares,
            // si se puede montar realizar la ejecución del programa para que dibuje el triangulo.
            
            int p;
            Console.WriteLine("Ingrese un numero para crear una piramide:  ");
            p = Convert.ToInt32(Console.ReadLine());

            if (p == 1 || p == 3 || p == 6 || p == 10 || p == 15 || p == 21 || p == 28 || p == 36 || p == 45 ||
                p == 55 || p == 66 || p == 78 || p == 91 || p == 105 || p == 120 || p == 136 || p == 153 ||
                p == 171 || p == 190 || p == 210 || p == 231 || p ==253 || p == 276 || p ==300 || p == 325 ||
                p == 351 || p == 378 || p == 406 || p == 435 || p == 465|| p ==496 || p ==528 || p == 561||
                p == 595 || p ==630|| p == 666|| p == 703)
            {
                if (p == 1)
                {
                    Console.WriteLine("                                                           * ");
                }


                if (p == 3)
                {
                    Console.WriteLine("                                                            * ");
                    Console.WriteLine("                                                           * * ");
                }
                if (p == 6)
                {
                    Console.WriteLine("                                                            * ");
                    Console.WriteLine("                                                           * * ");
                    Console.WriteLine("                                                          * * * ");
                }
                if (p == 10)
                {
                    Console.WriteLine("                                                            * ");
                    Console.WriteLine("                                                           * * ");
                    Console.WriteLine("                                                          * * * ");
                    Console.WriteLine("                                                         * * * * ");
                }
                if (p == 15)
                {
                    Console.WriteLine("                                                           * ");
                    Console.WriteLine("                                                          * * ");
                    Console.WriteLine("                                                         * * * ");
                    Console.WriteLine("                                                        * * * * ");
                    Console.WriteLine("                                                       * * * * * ");
                }
                if (p == 21)
                {
                    Console.WriteLine("                                                            * ");
                    Console.WriteLine("                                                           * * ");
                    Console.WriteLine("                                                          * * * ");
                    Console.WriteLine("                                                         * * * * ");
                    Console.WriteLine("                                                        * * * * * ");
                    Console.WriteLine("                                                       * * * * * * ");
                }
                if (p == 28)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                }
                if (p == 36)
                {
                    Console.WriteLine("                                                           * ");
                    Console.WriteLine("                                                          * * ");
                    Console.WriteLine("                                                         * * * ");
                    Console.WriteLine("                                                        * * * * ");
                    Console.WriteLine("                                                       * * * * * ");
                    Console.WriteLine("                                                      * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * ");
                }
                if (p == 45)
                {
                    Console.WriteLine("                                                           * ");
                    Console.WriteLine("                                                          * * ");
                    Console.WriteLine("                                                         * * * ");
                    Console.WriteLine("                                                        * * * * ");
                    Console.WriteLine("                                                       * * * * * ");
                    Console.WriteLine("                                                      * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * ");
                }
                if (p == 55)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                }
                if (p == 66)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                }
                if (p == 78)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                }
                if (p == 91)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                }
                if (p == 105)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                }
                if (p == 120)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                }
                if (p == 136)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                }
                if (p == 153)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                }
                if (p == 171)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 190)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 210)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 231)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 253)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 276)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 300)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 325)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 351)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 378)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 406)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 435)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 465)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                }
                if (p == 496)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                               * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                }
                if (p == 528)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                               * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                              * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 561)
                {
                    Console.WriteLine("                                                            * ");
                    Console.WriteLine("                                                           * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                               * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                              * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 595)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                               * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                              * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                            * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 630)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                               * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                              * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                            * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                           * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 666)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                               * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                              * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                            * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                           * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                          * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
                if (p == 703)
                {
                    Console.WriteLine("                                                             * ");
                    Console.WriteLine("                                                            * * ");
                    Console.WriteLine("                                                           * * * ");
                    Console.WriteLine("                                                          * * * * ");
                    Console.WriteLine("                                                         * * * * * ");
                    Console.WriteLine("                                                        * * * * * * ");
                    Console.WriteLine("                                                       * * * * * * * ");
                    Console.WriteLine("                                                      * * * * * * * * ");
                    Console.WriteLine("                                                     * * * * * * * * * ");
                    Console.WriteLine("                                                    * * * * * * * * * * ");
                    Console.WriteLine("                                                   * * * * * * * * * * * ");
                    Console.WriteLine("                                                  * * * * * * * * * * * * ");
                    Console.WriteLine("                                                 * * * * * * * * * * * * * ");
                    Console.WriteLine("                                                * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                               * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                              * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                             * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                            * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                           * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                          * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                         * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                        * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                       * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                      * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                     * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                    * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                   * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                  * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                                * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                               * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  ");
                    Console.WriteLine("                              * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                            * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                           * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                          * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                    Console.WriteLine("                         * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                }
            }
            else
            {
             Console.WriteLine("No es posible organizar los productos en forma de piramide");
            }
                Console.ReadKey();
        }
    }
}
