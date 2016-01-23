using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЁМ РАЗМЕР ДОСКИ (В ИТОГЕ ПОСТАВИТЬ "7")
            int DeskSize = 4;

            int[,] Permutation = new int[DeskSize,DeskSize];

            // ЗАПОЛНЯЕМ ВЕРХНИЙ РЯД НАТУРАЛЬНЫМИ ЧИСЛАМИ ОТ 0 ПО ПОРЯДКУ (0, 1, 2...)
            int Ordinate = 0;
            for (int Abscissa = 0; Abscissa < DeskSize; Abscissa++)
            {
                Permutation[Abscissa, Ordinate] = Abscissa;
                Console.WriteLine(Permutation[Abscissa, Ordinate]);
            }


    

            Ordinate = 1;
            int LocalDeskSize = DeskSize;

            for (int Abscissa = 0; Abscissa < LocalDeskSize; Abscissa++)
            {
                Permutation[DeskSize - Ordinate, Ordinate] = Permutation[Abscissa, Ordinate - 1];

                for (int LocalIndex = 0; LocalIndex < Abscissa; LocalIndex++)
                {
                    Permutation[LocalIndex, Ordinate] = Permutation[LocalIndex, Ordinate - 1];
                }

                for (int LocalIndex = Abscissa; LocalIndex < DeskSize-1; LocalIndex++)
                {
                    Permutation[LocalIndex, Ordinate] = Permutation[LocalIndex + 1, Ordinate - 1];
                }

                Console.WriteLine();
                for (int k = 0; k < DeskSize; k++)
                {
                    Console.WriteLine(Permutation[k, 1]);
                }
            }

            /*
            Ordinate = 1;
            //            int LocalDeskSize = DeskSize;

            for (int LocalDeskSize = DeskSize; LocalDeskSize > 0; LocalDeskSize--)
            {

                for (int Abscissa = 0; Abscissa < LocalDeskSize; Abscissa++)
                {
                    Permutation[LocalDeskSize - Ordinate, Ordinate] = Permutation[Abscissa, Ordinate - 1];

                    for (int LocalIndex = 0; LocalIndex < Abscissa; LocalIndex++)
                    {
                        Permutation[LocalIndex, Ordinate] = Permutation[LocalIndex, Ordinate - 1];
                    }

                    for (int LocalIndex = Abscissa; LocalIndex < LocalDeskSize - 1; LocalIndex++)
                    {
                        Permutation[LocalIndex, Ordinate] = Permutation[LocalIndex + 1, Ordinate - 1];
                    }

                    Console.WriteLine();
                    for (int k = 0; k < LocalDeskSize; k++)
                    {
                        Console.WriteLine(Permutation[k, Ordinate]);
                    }
                }
            }
            Console.ReadLine();
        }
        */

        Console.ReadLine();
        }
    }
}
