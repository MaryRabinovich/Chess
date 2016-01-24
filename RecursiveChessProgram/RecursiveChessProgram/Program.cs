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

            Console.WriteLine("Вот они, правильные доски: ");
            Console.WriteLine();

            int[] NumberOfFittingDesks = new int[1];
            NumberOfFittingDesks[0] = PutQueensOnTheDesk(Desk, DeskSize, 0, NumberOfFittingDesks);

            Console.Write("Количество правильных досок равно ");
            Console.Write(NumberOfFittingDesks[0]);
            Console.ReadLine();

        }

        static int GetDeskSize()
        {
            int DeskSize = 4;
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.Write("(я - функция GetDeskSize, сейчас я задаю доску ширины ");
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
                    PutQueensOnTheDesk(NewSlice, DeskSize, SliceIndex + 1, NumberOfFittingDesks);
                }
            }
            else NumberOfFittingDesks[0] = NumberOfFittingDesks[0] + CheckDesk(Slice, DeskSize);

            return NumberOfFittingDesks[0];
        }

        static int CheckDesk(int[,] Desk, int DeskSize)
        {
            int DeskQuality = 1;
            DeskQuality = DeskQuality * CheckColumns(Desk, DeskSize);
            DeskQuality = DeskQuality * CheckRows(Desk, DeskSize);
            DeskQuality = DeskQuality * CheckXplusY(Desk, DeskSize);
            DeskQuality = DeskQuality * CheckYminusX(Desk, DeskSize);

            if (DeskQuality == 1) ShowDesk(Desk, DeskSize);

            return DeskQuality;
        }

        static int CheckColumns(int[,] Desk, int DeskSize)
        {
            int FitDesk = 1;
            int ColSum; 
            for (int Col = 0; Col < DeskSize; Col++)
            {
                ColSum = 0;
                for (int Row = 0; Row < DeskSize; Row++) ColSum = ColSum + Desk[Col, Row];
                if (ColSum != 1) FitDesk = 0;
            }
            return FitDesk;
        } 

        static int CheckRows(int[,] Desk, int DeskSize)
        {
            int FitDesk = 1;
            int RowSum;
            for (int Row = 0; Row < DeskSize; Row++)
            {
                RowSum = 0;
                for (int Col = 0; Col < DeskSize; Col++) RowSum = RowSum + Desk[Col, Row];
                if (RowSum != 1) FitDesk = 0;
            }
            return FitDesk;
        } 

        static int CheckXplusY(int[,] Desk, int DeskSize)
        {
            int FitDesk = 1;
            int DiagonalSum;
            int Row = 0;
            for (int XplusY = 0; XplusY < 2*DeskSize; XplusY++)
            {
                DiagonalSum = 0;
                for (int Col = 0; Col < DeskSize; Col++)
                {
                    Row = XplusY - Col;
                    if (Row > -1 && Row < DeskSize) DiagonalSum = DiagonalSum + Desk[Col, Row];
                }
                if (DiagonalSum > 1) FitDesk = 0;
            }
            return FitDesk;
        } 

        static int CheckYminusX(int[,] Desk, int DeskSize)
        {
            int FitDesk = 1;
            int DiagonalSum;
            int Row = 0;
            for (int YminusX = - DeskSize; YminusX < DeskSize; YminusX++)
            {
                DiagonalSum = 0;
                for (int Col = 0; Col < DeskSize; Col++)
                {
                    Row = Col - YminusX;
                    if (Row > -1 && Row < DeskSize) DiagonalSum = DiagonalSum + Desk[Col, Row];
                }
                if (DiagonalSum > 1) FitDesk = 0;
            }
            return FitDesk;
        }
    }
}
