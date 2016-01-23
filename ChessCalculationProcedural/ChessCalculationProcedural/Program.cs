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
            int[] NewLine = Permutation(Line, LocalDeskSize);
            for (int i = 0; i < DeskSize; i++)
            {
                Console.WriteLine(NewLine[i]);
            }

            Console.ReadLine();
        }


        // метод может сам себя вызывать: http://professorweb.ru/my/csharp/charp_theory/level5/5_11.php

        static int[] Permutation(int[] Line, int LocalDeskSize)
        {
            if (LocalDeskSize == 1)
            {
                return Line;
            }
            else return Line;
        } 
    }
}
