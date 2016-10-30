//Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2) .
using System;
    class PointInCircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int radius = 2;
            bool isInCircle = true;
            isInCircle = ((x*x)+(y*y)<(radius *radius)); 
                Console.WriteLine(isInCircle);
            }

        }
    
