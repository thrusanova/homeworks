using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VariableLengthCodes
{
    static void Main(string[] args)
    {
        /*
         * 173 222 
4
 2
a1
b3
c4
*/
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Dictionary<string,char> dict = new Dictionary<string,char>();
        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();
            char letter = input[0];
            string count = string.Empty;
            for (int j = 1; j < input.Length; j++)
            {
                count += input[j];
            }
            string num = new string('1',int.Parse(count));
            dict.Add(num, letter);
        }
        StringBuilder sb = new StringBuilder();
        foreach (var item in numbers)
        {
            sb.Append(Convert.ToString(item, 2).PadLeft(8, '0'));
        }
        string[] result = sb.ToString().Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder output = new StringBuilder();
        foreach (var item in result)
        {
            output.Append(dict[item]);
        }
        Console.WriteLine(output);
    }
}