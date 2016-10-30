using System;

class CharCompare
{
    static void Main()
    {
        char[] firstArray = { 'a', 'b', 'c', 'd', 'e' };
        char[] secondArray = { 'a', 'b', 'c', 'd', 'e' };
        bool areLexiEqual = true;
        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areLexiEqual = false;
                    Console.WriteLine("The array are not equal");
                }
            }
            Console.WriteLine("The array are equal");
        }
        else if (firstArray.Length > secondArray.Length)
        {
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    areLexiEqual = true;
                }
            }
            Console.WriteLine("The second array is first.");
        }

        else
        {
            areLexiEqual = false;
            Console.WriteLine("The first array is first");
        }

    }
}

