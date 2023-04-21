using System;

namespace Library.figures.@abstract
{
    public interface IFigure<T>  
    {
        public double Area { get; }
        
        public double Perimeter { get; }
        
        public FigureType FigureType { get; }

        public T FigureId { get; }
        
        public object Title => FigureType.ToString();

        // public Figure(int figureId)
        // {
        //     FigureId = figureId;
        // }

        public T TestMethod();
        
        public string GetTitle()
        {
            return $"{FigureId}:{Title}";
        }
        
        public int GetAnglesCount();

        [Author("Stanislav", "21/04/2023")]
        public FigureColor GetColor()
        {
            return FigureColor.Black;
        }
        
    }

    public enum FigureType
    {
        Circle, 
        Triangle, 
        Square,
        Cube
    }

    public enum FigureColor
    {
        Black,
        White
    }

    

   
    
}