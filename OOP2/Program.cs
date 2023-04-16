using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HendesiShekiller
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(6, 8);
            Triangle triangle = new Triangle(6, 8, 10);

            Console.WriteLine("Circle:");
            Console.WriteLine($"Area: {circle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
            Console.WriteLine();

            Console.WriteLine("Rectangle:");
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
            Console.WriteLine();

            Console.WriteLine("Triangle:");
            Console.WriteLine($"Area: {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
            Console.WriteLine();
        }
        interface IFigure
        {
            double CalculateArea();
        }
        interface IPerimeter
        {
            double CalculatePerimeter();
        }
        
    }
}
