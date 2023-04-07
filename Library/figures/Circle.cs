using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public class Circle : ITwoDimensionFigure
    {
        private double _r;

        public Circle(double r, int figureId)
        {
            _r = r;
        }
        
        public double R => _r;
        public double Diameter => 2 * _r;

        public double Area => Math.PI * Math.Pow(_r, 2);
        public double Perimeter => 2 * Math.PI * _r; 
        
        public FigureType FigureType => FigureType.Circle;
        public int FigureId { get; }

        public int GetAnglesCount()
        {
            return 0;
        }
    }


    
    
}