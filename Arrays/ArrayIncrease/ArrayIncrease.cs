//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
using System;
class ArrayIncrease
{
    static void Main()
    {
        int input =int.Parse( Console.ReadLine());
        int[] myArray = new int[input];
        for (int i = 0; i < input; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        //int[] myArray = { 3, 2, 3, 4, 2, 2, 4 };
        int count = 1;
        int maxLenght = 0;
        int lastElement = 0;
        for (int i = 0; i < myArray.Length-1; i++)
        {
            if (myArray[i] < myArray[i+1])
            {
                count++;
            }
            else
            {
                if (count>maxLenght)
                {
                    maxLenght = count;
                    lastElement = i;
                }
                count = 1;
            }
        }
        if (count>maxLenght)
        {
            count = maxLenght;
            lastElement = myArray.Length - 1;
        }
        count = 1;
        Console.WriteLine(maxLenght);
      

}
}

       

