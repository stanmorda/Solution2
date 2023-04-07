using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public sealed class Square : TwoDimensionFigure
    {
        private double _a;

        private const int Angles = 4;
        
        public Square(double a, int figureId) : base(figureId)
        {
            _a = a;
        }

        public double A => _a;

        public double Diagonal => Math.Sqrt(2) * _a;

        public override double Area => _a * _a;
        
        public override double Perimeter => 4 * _a;
        
        public override FigureType FigureType => FigureType.Square;
        public override int GetAnglesCount()
        {
            return Angles;
        }
    }

    
}