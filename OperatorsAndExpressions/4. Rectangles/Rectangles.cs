//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter height of a rectangle: ");
            float h = float.Parse(Console.ReadLine());
            Console.Write("Enter weight of a rectangle: ");
            float a = float.Parse(Console.ReadLine());
            double perimeter = 2 * (a + h);
            double area = (a * h);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
        }
    }

