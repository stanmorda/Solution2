using System;

namespace Figures.figures
{
    public class Square : Figure
    {
        private double _a;

        public Square(double a)
        {
            _a = a;
        }

        public double A => _a;

        public double Diagonal => Math.Sqrt(2) * _a;

        public override double Area => _a * _a;
        
        public override double Perimeter => 4 * _a;
        
        public override FigureType FigureType => FigureType.Square;


        public override string GetTitle()
        {
            return "Square";
        }
    }
}