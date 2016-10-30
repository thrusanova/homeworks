//Write a program that reads the radius  r  of a circle and prints its perimeter and area formatted with  2  digits after the decimal point.
using System;
class CirclePerimeterAndArea
{
static void Main()

{
    Console.Write("Enter r of a circle: ");
    double r = double.Parse(Console.ReadLine());
    double perimeter = 2 *Math.PI * r;
    double area = Math.PI * r * r;
    Console.WriteLine("{0:F2}",perimeter);
    Console.WriteLine("{0:F2}",area);
}
}
