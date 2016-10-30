using System;

class compareArrays
{
    static void Main()
    {
        Console.Write("Enter the array lenght n: ");
        int n = int.Parse(Console.ReadLine());
        int[] FirstArray = new int[n];
        int[] SecondArray = new int[n];
      
       for (int i = 0; i < n; i++)
          {
           FirstArray[i] = int.Parse(Console.ReadLine());
          }
        for (int i = 0; i < n; i++)
         {
          SecondArray[i] = int.Parse(Console.ReadLine());
          }
       Array.Sort(FirstArray);
        Array.Sort(SecondArray);
       bool isEqual = true;
        for (int i = 0; i < FirstArray.Length; i++)
        {
           if (FirstArray[i] != SecondArray[i])
          {
                isEqual = false;
                break;
           }
       }
        Console.WriteLine("The arrays are equal :{0}", isEqual);

    }
}

