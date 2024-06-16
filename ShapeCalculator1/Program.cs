using System;

namespace ShapeAreaCalculator
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class ShapeCal
    {
        public static void Main(string[] args)
        {
            // Get user input for Circle
            Console.Write("Enter the radius of the circle: ");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(circleRadius);
            Console.WriteLine($"Area of the circle: {circle.GetArea()}");

            // Get user input for Rectangle
            Console.Write("Enter the width of the rectangle: ");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double rectangleHeight = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight);
            Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}");
        }
    }
}
