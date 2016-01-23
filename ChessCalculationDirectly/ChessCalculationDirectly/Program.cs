using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCalculationDirectly
{
    class Program
    {
        static void Main(string[] args)
        {
            int DeskSize = GetDeskSize();

            int[] NewLine = new int[DeskSize];
            NewLine = GetNewLine(DeskSize);

            ShowLine(NewLine);

            int Element = ChooseAnElement(NewLine);
            
        }




        static int GetDeskSize()
        {
            return 4;
        }

        static int[] GetNewLine(int DeskSize)
        {
            int[] Line = new int[DeskSize];
            for (int i = 0; i < DeskSize; i++)
            {
                Line[i] = i;
            }
            return Line;
        }

        static void ShowLine(int[] Line)
        {
            for (int i = 0; i < Line.Length; i++)
            {
                Console.WriteLine(Line[i]);
            }
            Console.ReadLine();
        }
    }
}


