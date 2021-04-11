using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork3.FolderClasses
{
    class ClassPhoneBook
    {
        public static void PhoneBook()
        {
            string[,] array = { { "Иван", "8-956-564-85-52" }, { "Артем", "8-954-963-52-56" }, { "Антон", "8-956-214-65-32" }, { "Илья", "8-985-987-52-63" }, { "Юрий", "8-987-965-63-52" } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            
            Console.WriteLine($"   Имя\t\t Номер телефона");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t\t");
                }
                Console.WriteLine();
            }
        }
    }
}
