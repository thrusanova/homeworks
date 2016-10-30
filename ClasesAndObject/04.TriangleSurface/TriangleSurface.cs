//Write methods that calculate the surface of a triangle by given: ◦ Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use  System.Math .

using System;

    class TriangleSurface
    {
        static double CalcArea(double side, double altitude)
        {
            double area = side * altitude;
            Console.Write("The area of the triangle is:");
            return area;
        }
        static double CalcArea(double side1, double side2, double side3)
        {
            //herons formula-S=sqrt(p(p-a)(p-b)(p-c))
            double perimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            Console.Write("The area of the triangle is:");
            return area;
        }
        static double CalcArea(double side1, double side2, int angle)
        {
             double area = (side1 * side2*Math.Sin((angle*Math.PI)/180)) / 2;
             Console.Write("The area of the triangle is:");
             return area; 
        }
        static void Main()
        {
            Console.Write("Enter 1 if you want to find the area of a triangle by given a  side and an altitude(");
            Console.WriteLine();
            Console.Write("Enter 2  if you want to find the area of a triangle by given three sides");
            Console.WriteLine();
            Console.Write("Enter 3  if you want to find the area of a triangle by given two sides and an angle between them");
            Console.WriteLine();
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("Please enter a side and an altitude:");
                    double a = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine(CalcArea(a,h));
                    break;
                case 2: Console.WriteLine("Please enter three sides");
                    double c = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(CalcArea(b, c,d));
                    break;
                case 3: Console.WriteLine("Please enter three sides");
                    double firstSide = double.Parse(Console.ReadLine());
                    double secondSide = double.Parse(Console.ReadLine());
                    int angle = int.Parse(Console.ReadLine());
                    Console.WriteLine(CalcArea(firstSide, secondSide, angle));
                    break;
                default: Console.WriteLine("Wrong choise.");
                    break;
            }

        }
    }

