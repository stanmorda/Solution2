using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public class Triangle<T> : ITwoDimensionFigure<T>
    {
        private double _a, _b, _c;

        private const int Angles = 3;
        
        public Triangle(double a, double b, double c, T figureId) 
        {
            _a = a;
            _b = b;
            _c = c;
            FigureId = figureId;
        }

        public double A => _a;

        public double B => _b;

        public double C => _c;

        public double Area => throw new Exception("Не умею");
        public double Perimeter => _a + _b + _c;
        

        public FigureType FigureType => FigureType.Triangle;
        public T FigureId { get; }

        public T TestMethod()
        {
            return FigureId;
        }

        public  int GetAnglesCount()
        {
            return Angles;
        }

        public FigureColor GetColor()
        {
            return FigureColor.White;
        }
        
    }
}