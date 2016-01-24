using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveChessProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int DeskSize = GetDeskSize();           

            int[,] Desk = new int[DeskSize, DeskSize];
            Desk = CreateEmptyDesk(DeskSize);

            int[] NumberOfFittingDesks = new int[1];
            NumberOfFittingDesks[0] = PutQueensOnTheDesk(Desk, DeskSize, 0, NumberOfFittingDesks);
            Console.Write("Количество нужных досок равно ");
            Console.Write(NumberOfFittingDesks[0]);
            Console.ReadLine();


        }

        static int GetDeskSize()
        {
            int DeskSize = 3;
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.Write("(это я, функция GetDeskSize, сейчас я задаю доску ширины ");
            Console.Write(DeskSize);
            Console.WriteLine(" )");
            Console.WriteLine();
            Console.ReadLine();
            return DeskSize;
        }

        static int[,] CreateEmptyDesk(int DeskSize)
        {
            int[,] EmptyDesk = new int[DeskSize, DeskSize];
            for (int Col = 0; Col < DeskSize; Col++)
                for (int Row = 0; Row < DeskSize; Row++)
                        EmptyDesk[Col, Row] = 0;
            return EmptyDesk;
        }

        static int[,] CopyDesk(int[,] Desk, int DescSize)
        {
            int[,] NewDesk = new int[DescSize, DescSize];
            for (int Col = 0; Col < DescSize; Col++)
                for (int Row = 0; Row < DescSize; Row++)
                    NewDesk[Col, Row] = Desk[Col, Row];
           // ShowDesk(NewDesk, DescSize);
            return NewDesk;
        }

        static void ShowDesk(int[,] Desk, int DeskSize)
        {
            for (int col = 0; col < DeskSize; col++)
            {
                for (int row = 0; row < DeskSize; row++)
                    Console.Write(Desk[col, row]);
                Console.WriteLine();
            }
            Console.WriteLine();
            /*
            Console.WriteLine("Нажмите любую клавишу");
            Console.WriteLine("(это я, функция ShowDesk)");
            Console.ReadLine();
            */
        }

        static int PutQueensOnTheDesk(int[,] Slice, int DeskSize, int SliceIndex, int[] NumberOfFittingDesks)
        {
            if (SliceIndex < DeskSize)
            {
                for (int i = 0; i < DeskSize; i++)
                {
                    int[,] NewSlice = new int[DeskSize, DeskSize];
                    NewSlice = CopyDesk(Slice, DeskSize);
                    NewSlice[SliceIndex, i] = 1;
                    if (SliceIndex == DeskSize - 1) ShowDesk(NewSlice, DeskSize);
                    PutQueensOnTheDesk(NewSlice, DeskSize, SliceIndex + 1, NumberOfFittingDesks);
                }
            }
            else NumberOfFittingDesks[0] = NumberOfFittingDesks[0] + CheckDesk(Slice, DeskSize, SliceIndex);

            return NumberOfFittingDesks[0];
        }



        // ЭТУ Я ДАЖЕ НЕ НАЧИНАЛА ТОЛКОМ.
        // ТУТ ДОЛЖНА БЫТЬ ПРОВЕРКА КОНКРЕТИЗИРОВАННОЙ ДОСКИ НА ПАРШИВОСТЬ, ПРИ ЗАДАННОЙ РАССТАНОВКЕ ФЕРЗЕЙ
        // СЕЙЧАС ОНА ПРОВЕРЯЕТ ВСЕГО ЛИШЬ УГЛОВОЙ ТЕРМИН:
        // ЕСЛИ ЕСТЬ КОРОЛЕВА В ЛЕВОМ ВЕРХНЕМ УГЛУ, ЭТО ТИПА ПОКА ПОДХОДЯЩАЯ ДОСОЧКА
        static int CheckDesk(int[,] Desk, int DeskSize, int SliceIndex)
        {
            return 1;
        }


    }
}
