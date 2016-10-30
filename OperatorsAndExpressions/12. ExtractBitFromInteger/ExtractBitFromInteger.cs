//Write an expression that extracts from given integer  n  the value of given bit at index  p .
using System;
class Bitwise
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        int lastBit = ((n >> p) & 1);
        Console.WriteLine(lastBit);
    }
}
 
