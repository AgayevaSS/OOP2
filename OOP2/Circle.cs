using System;

namespace HendesiShekiller
{
    internal partial class Program
    {
        class Circle : IFigure, IPerimeter
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            public double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

    }
}
