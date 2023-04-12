using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public sealed class Square : ITwoDimensionFigure<byte>
    {
        private double _a;

        private const int Angles = 4;
        
        public Square(double a, byte figureId)
        {
            _a = a;
        }

        public double A => _a;

        public double Diagonal => Math.Sqrt(2) * _a;

        public  double Area => _a * _a;
        
        public  double Perimeter => 4 * _a;
        
        public  FigureType FigureType => FigureType.Square;
        public byte FigureId { get; }

        public byte TestMethod()
        {
            return default(byte);
        }

        public  int GetAnglesCount()
        {
            return Angles;
        }
    }

    
}