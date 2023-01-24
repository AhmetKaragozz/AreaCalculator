using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator
{
    internal class AreaCalculator
    {
        public static double TriangleArea(double side1, double side2, double angle)
        {
            double area = (side1 * side2 * Math.Sin(angle)) / 2;
            return area;
        }

        public static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public static void RectangularArea(double side1, double side2)
        {
            double area = side1 * side2;
            Console.WriteLine("The area of the rectangle is: " + area);
        }

        public static double TrapezoidArea(double base1, double base2, double height)
        {
            double area = ((base1 + base2) * height) / 2;
            return area;
        }

        public static void Main(string[] args)
        {
            int choice;
            double side1, side2, angle, radius, base1, base2, height;

            Console.WriteLine("1. Triangle Area Calculation");
            Console.WriteLine("2. Circle Area Calculation");
            Console.WriteLine("3. Rectangular Area Calculation");
            Console.WriteLine("4. Trapezoid Area Calculation");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the sides of the triangle: ");
                    side1 = double.Parse(Console.ReadLine());
                    side2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the angle between the sides: ");
                    angle = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is: " + TriangleArea(side1, side2, angle));
                    break;

                case 2:
                    Console.WriteLine("Enter the radius of the circle: ");
                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the circle is: " + CircleArea(radius));
                    break;

                case 3:
                    Console.WriteLine("Enter the sides of the rectangle: ");
                    side1 = double.Parse(Console.ReadLine());
                    side2 = double.Parse(Console.ReadLine());
                    RectangularArea(side1, side2);
                    break;

                case 4:
                    Console.WriteLine("Enter the bases of the trapezoid: ");
                    base1 = double.Parse(Console.ReadLine());
                    base2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the trapezoid: ");
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the trapezoid is: " + TrapezoidArea(base1, base2, height));
                    break;

                case 5:
                    break;
            }
        }
    }
}
