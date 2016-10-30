//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;

    class UnicodeCharacters
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string unicode = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                unicode += string.Format("\\u{0:x4}", (int)text[i]);
            }
            Console.WriteLine(unicode);
        }
    }

