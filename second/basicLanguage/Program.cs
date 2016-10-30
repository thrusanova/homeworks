using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicLanguage
{
    class Program
    {
        static StringBuilder result = new StringBuilder();
    static    List<string> allComand = new List<string>();
        static void Main(string[] args)
        {
            ReadInput();
            TransformCommand();
            RunCommand();
            Console.WriteLine(result);

        }

        private static void RunCommand()
        {
            result.Clear();
           
            for (int i = 0; i < allComand.Count; i++)
            {
                int allLoop = 1;
                string[] subCommand = allComand[i].Split(new char[]{')'},StringSplitOptions.RemoveEmptyEntries);
                foreach (var command in subCommand)
                {
                    string currComand = command.TrimStart();
                    if (currComand.StartsWith("EXIT"))
                    {

                        return;
                    }
                    else if (currComand.StartsWith("PRINT"))
                    {

                        int paramStart = currComand.IndexOf("(") + 1;
                        string content = currComand.Substring(paramStart);
                        for (int j = 0; j < allLoop; j++)
                        {
                             result.Append(content);
                        }
                    }
                    else if (currComand.StartsWith("FOR")) 
                    {
                        int paramStart = currComand.IndexOf("(") + 1;
                        string allParam = currComand.Substring(paramStart);
                        if (allParam.Contains(","))
                        {
                            string[] loopParams = allParam.Split(',');
                            int a = int.Parse(loopParams[0]);
                            int b = int.Parse(loopParams[1]);
                            allLoop =allLoop* (b - a + 1);
                        }
                        else
                        {
                            int value = int.Parse(allParam);
                            allLoop = allLoop*value;
                        }
                    }
                }
               
            }
        }

        private static void TransformCommand()
        {
            string allInput = result.ToString();
            result.Clear();
            foreach (var symbol in allInput)
            {
                result.Append(symbol);
                if (symbol  == ';')
                {
                    allComand.Add(result.ToString());
                    result.Clear();
                }
            }
        }

        private static void ReadInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                result.AppendLine(input);
                if (input.Contains("EXIT;"))
                {
                    break;
                }
            }
        }
    }
}
