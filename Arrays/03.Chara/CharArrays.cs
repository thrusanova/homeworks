//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
using System.Collections.Generic;

class LexicographicCharArrayComparer : Comparer<char[]>
{
    public override int Compare(char[] x, char[] y)
    {
        if (x == null || y == null)
            return Default.Compare(x, y);

        int lengthComp = x.Length.CompareTo(y.Length);
        if (lengthComp != 0)
            return lengthComp;

        return StringComparer.Ordinal.Compare(new string(x), new string(y));
    }
}
class CharCompare
{
    static void Main()
    {
        char[] firstArray = Console.ReadLine().ToCharArray();
        char[] secondArray = Console.ReadLine().ToCharArray();
        var comparer = new LexicographicCharArrayComparer();
        var result = comparer.Compare(firstArray, secondArray);
        if (result < 0)
            Console.WriteLine("<");
        else if (result == 0)
            Console.WriteLine("=");
        else
            Console.WriteLine(">");
    }
}

