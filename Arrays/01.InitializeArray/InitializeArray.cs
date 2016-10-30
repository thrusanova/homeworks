//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.
using System;

class InitializeArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int [] myArray=new int[n];
        for (int i = 0; i < n; i++)
        {
            myArray[i] = i * 5;
        }
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
       

    }
}
