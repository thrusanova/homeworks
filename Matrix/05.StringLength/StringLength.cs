//You are given an array of strings. Write a method that sorts
//the array by the length of its elements (the number of characters composing them).
using System;
using System; 
using System.Collections.Generic; 
 using System.Linq; 
using System.Text; 
 using System.Threading.Tasks; 

 class StringLength
    {
        static void Main()
        {
            System.Console.Write("Unsorted string array is:");
            string [] array =new string [] { "eery", "rtyry", "yrytjkgd", "yt", "yrty" };
            Console.WriteLine(string.Join(" ", array));
            Sort(array);
            System.Console.Write("Sorted string arey is:");
            Console.WriteLine(string.Join(" ",array));
        }
        static void Sort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j].Length<array[i].Length)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
        }
    }

