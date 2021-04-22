using System;

namespace SOLID_test
{
    public abstract class Shape
        // Interfacing an abstraction. (SRP, OCP, LSP, DIP)

        // ISP is not violated for the programs simplicity. 3d shapes would create violations. 
        // New interfaces for 3d shapes would need to extend this 2d one to correctly apply ISP. 
    {
        public abstract double Area();
        public abstract string GetShape();
    }
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
        public override string GetShape()
        {
            return "Rectangle";
        }

    }

    public class Circle : Shape {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
        public override string GetShape()
        {
            return "Circle";
        }
    }

    public class AreaCalc
    {
        public double SumArea(Shape[] shapes)
        {
            double area = 0;
            foreach(var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
