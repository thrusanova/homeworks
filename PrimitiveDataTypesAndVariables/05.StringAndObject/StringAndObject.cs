//Declare two string variables and assign them with  Hello  and  World .
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;
class StringAndObject
{
    static void Main()
    {
        string firstNum = "Hello";
        string secondNum = "World";
        object sum = firstNum + " " + secondNum + "!";
        string finalSum = (string)sum;
        Console.WriteLine(sum);
    }
}