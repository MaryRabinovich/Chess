using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCalculationProcedural
{
    class Program
    {
        static void Main(string[] args)
        {
            int DeskSize = 3;
            int[] Line = new int[DeskSize];

            for (int i = 0; i < DeskSize; i++)
            {
                Line[i] = i;
                Console.WriteLine(Line[i]);
            }

            Console.WriteLine();

            int LocalDeskSize = 1;
            int[] NewLine = PermuteLine(Line, DeskSize, LocalDeskSize);
            for (int i = 0; i < DeskSize; i++)
            {
                Console.WriteLine(NewLine[i]);
            }

            Console.ReadLine();
        }


        // метод может сам себя вызывать: http://professorweb.ru/my/csharp/charp_theory/level5/5_11.php

        static int[] PermuteLine(int[] Line, int DeskSize, int LocalDeskSize)
        {
            if (LocalDeskSize == 1)
            {
                return Line;
            }
            else
            {
                int[] NewLine = new int[DeskSize];
                LocalDeskSize--;
                // переписываем хвост
                for (int Tail = LocalDeskSize; Tail < LocalDeskSize; Tail++) NewLine[Tail] = Line[Tail];
                // делаем цикл по вытаскиваемому элементу
                for (int ChoosenIndex = 0; ChoosenIndex < LocalDeskSize; ChoosenIndex++)
                {
                    NewLine[LocalDeskSize] = Line[ChoosenIndex];
                    for (int i = 0; i < ChoosenIndex; i++) NewLine[i] = Line[i];
                    for (int i = ChoosenIndex; i < LocalDeskSize; i++) NewLine[i] = Line[i + 1];
                    PermuteLine(NewLine, DeskSize, LocalDeskSize);
                }
            }
        } 
    }
}
