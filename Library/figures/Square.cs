using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public sealed class Square : ITwoDimensionFigure
    {
        private double _a;

        private const int Angles = 4;
        
        public Square(double a, int figureId)
        {
            _a = a;
        }

        public double A => _a;

        public double Diagonal => Math.Sqrt(2) * _a;

        public  double Area => _a * _a;
        
        public  double Perimeter => 4 * _a;
        
        public  FigureType FigureType => FigureType.Square;
        public int FigureId { get; }

        public  int GetAnglesCount()
        {
            return Angles;
        }
    }

    
}