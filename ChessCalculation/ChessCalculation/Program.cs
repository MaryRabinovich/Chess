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

            // ЗАПОЛНЯЕМ ПОСЛЕДОВАТЕЛЬНО НИЖНИЕ РЯДЫ МАТРИЦЫ, ОТ ВТОРОГО К ПОСЛЕДНЕМУ, 
            // ВЫТАСКИВАЯ ПЕРЕСТАНОВКУ В КОНЕЦ СТРОКИ
/*            for (int Ordinate = 1; Ordinate < DeskSize; Ordinate++)
            {
                // переписываем хвост предыдущей строки
                for (int Abscissa = DeskSize - Ordinate + 1; Abscissa < DeskSize; Abscissa++)
                {
                    Permutation[Abscissa, Ordinate] = Permutation[Abscissa, Ordinate - 1];
                }

            }
            */

    

            Ordinate = 1;

            for (int Abscissa = 0; Abscissa < DeskSize; Abscissa++)
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

            Console.ReadLine();
        }
    }
}
