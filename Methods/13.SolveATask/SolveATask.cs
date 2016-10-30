//Write a program that can solve these tasks: ◦ Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation  a * x + b = 0  

//reate appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data: ◦ The decimal number should be non-negative
//The sequence should not be empty
// a  should not be equal to  0  

using System;

class SolveATask
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program can solve several task.");
        Console.WriteLine("If you want to reverse the digit of a number press 1");
        Console.WriteLine("If you want to calculates the average of a sequence of integers press 2");
        Console.WriteLine("If you want to solves a linear equation  a * x + b = 0  press 3");
        Console.WriteLine("Please make you choise:");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("Enter the number you want to reverse:");
                int n = int.Parse(Console.ReadLine());
                int revNumber = Reverse(n);
                Console.WriteLine(revNumber);
                break;
            case 2:
                Console.Write("Enter the sequence you want to calculate with intervals: ");
                string inputArray = Console.ReadLine();
                if (inputArray == "0")
                {
                    Console.WriteLine("The sequence should not be empty.");
                    break;
                }
                char[] delimiter = new char[] { ',', ' ' };
                string[] input = inputArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                int[] arr = new int[input.Length];  
                for (int i = 0; i < input.Length; i++)
                    {
                          arr[i] = int.Parse(input[i]);
                    }
                Average(arr, input.Length);
                 break;
            case 3:
                 Console.WriteLine("Enter  the coefficients a and b of the linear equation you want to solve:");
                 Console.Write("a=");
                 double a = double.Parse(Console.ReadLine());
                 Console.Write("b=");
                 double b = double.Parse(Console.ReadLine());
                 SolveEquation(a, b);
                 break;
        }
    }
    static void Average(int[]array,int numElemens)
    { 
            double averageResult = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            averageResult = sum / array.Length;
            Console.WriteLine("The average of your sequence is: {0}.", averageResult);
     }
   
    static int Reverse(int num1)
    {
        string num = string.Empty;
        if (num1 < 0)
        {
            num += "-";
            num1 *= -1;
        }
        while (num1 != 0)
        {
            int digit = num1 % 10;
            num += digit;
            num1 /= 10;
        }
        num1 = int.Parse(num);
        return num1;
    }
    static void SolveEquation(double a, double b)
    {
        if (a==0)
        {
            Console.WriteLine("Wrong number!a must be different from 0");
        }
        else
        {
            double result = -b / a;
            Console.WriteLine("The result of the equation is {0}", result);
        }
        
    }
}



