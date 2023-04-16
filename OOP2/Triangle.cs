using System;

namespace HendesiShekiller
{
    internal partial class Program
    {
        class Triangle : IFigure, IPerimeter
        {
            public double SideA { get; set; }
            public double SideB { get; set; }
            public double SideC { get; set; }

            public Triangle(double sideA, double sideB, double sideC)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }

            public double CalculateArea()
            {
                double p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }

            public double CalculatePerimeter()
            {
                return SideA + SideB + SideC;
            }
        }

    }
}
