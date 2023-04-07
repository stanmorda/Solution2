using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public class Circle : TwoDimensionFigure
    {
        private double _r;

        public Circle(double r, int figureId) : base(figureId) 
        {
            _r = r;
        }
        
        public double R => _r;
        public double Diameter => 2 * _r;

        public override double Area => Math.PI * Math.Pow(_r, 2);
        public override double Perimeter => 2 * Math.PI * _r; 
        
        public override FigureType FigureType => FigureType.Circle;
        public override int GetAnglesCount()
        {
            return 0;
        }
    }

    public abstract class TringleCircle : Figure
    {
        protected TringleCircle(int figureId) : base(figureId)
        {
        }
    }
    
    
}