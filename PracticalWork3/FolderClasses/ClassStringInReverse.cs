using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork3.FolderClasses
{
    class ClassStringInReverse
    {
        public static void StringInReverse(string text)
        {
            for (int i = text.Length-1; i >-1; i--)
            {
                Console.Write(text[i]);
            }

        }
    }
}
