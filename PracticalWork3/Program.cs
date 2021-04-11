using System;

namespace PracticalWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------Задание 1------------------------");
            Console.WriteLine("Введите количество строк в массиве");
            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве");
            int column = Int32.Parse(Console.ReadLine());
            FolderClasses.ClassTwoArrayOnTheDiagonal.TwoArrayOnTheDiagonal(row, column);

            Console.WriteLine("------------------------Задание 2------------------------");
            FolderClasses.ClassPhoneBook.PhoneBook();

            Console.WriteLine("------------------------Задание 3------------------------");
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            FolderClasses.ClassStringInReverse.StringInReverse(text);
            Console.WriteLine();

            Console.WriteLine("------------------------Задание 4------------------------");
            int[] array = { 1, 5, 6, 7, 8, 9, 4, 2, 6, 7, 2, 6, 4 };
            Console.WriteLine("На сколько позиций будем смещать массив?");
            int n = Int32.Parse(Console.ReadLine());
            
           FolderClasses.ClassPr4.arrayNOffset(array,n);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
