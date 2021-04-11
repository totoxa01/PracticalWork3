using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork3.FolderClasses
{
    class ClassTwoArrayOnTheDiagonal
    {
        public static void TwoArrayOnTheDiagonal(int row, int column)
        {
            int[,] array = new int[row, column];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 9);
                }
            }
            int padLeft = 0;
            foreach (var element in array)
            {
                Console.WriteLine(element.ToString().PadLeft(padLeft += 2));
            }
            Console.ReadKey();
        }
    }
}
