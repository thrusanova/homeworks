//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression:  ((a+b)/5-d) . Example of incorrect expression:  )(a+b)) .

using System;
class CorrectBrackets
{
    static void Main()
    {
        string expression = Console.ReadLine();
        int firstCount = 0;
        int secondCount = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[0] == ')' || expression[expression.Length - 1] == '(')
            {
                Console.WriteLine("incorect brackets");
                break;
            }
            else
            {
                if (expression[i] == '(')
                {
                    firstCount++;
                }
                else if (expression[i] == ')')
                {
                    secondCount++;
                }
            }

        }

        if (firstCount==secondCount && firstCount!=0 && secondCount!=0)
        {
            Console.WriteLine("The brackets are correct");
        }
        else
        {
            Console.WriteLine("The brackets are not correct");
        }
    }

}

