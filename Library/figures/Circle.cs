using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public class Circle : ITwoDimensionFigure<string>
    {
        private double _r;

        public Circle(double r, string figureId)
        {
            _r = r;
            FigureId = figureId;
        }
        
        public double R => _r;
        public double Diameter => 2 * _r;

        public double Area => Math.PI * Math.Pow(_r, 2);
        public double Perimeter => 2 * Math.PI * _r; 
        
        public FigureType FigureType => FigureType.Circle;
        public string FigureId { get; }

        public string TestMethod()
        {
            return "blabalbal";
        }

        public int GetAnglesCount()
        {
            return 0;
        }
        
    }


    
    
}