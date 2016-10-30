using System;
//Write an expression that checks for given point (x, y) if it is within the circle  K({1, 1}, 1.5)  and out of the rectangle  R(top=1, left=-1, width=6, height=2) .
class InsideCircleOutsideRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = 1.5;
            bool isPoint;

            if (((x - 1) * (x - 1) + (y - 1) * (y- 1)<radius*radius) && (y >1))
            {
                isPoint = true;
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }

