namespace Library.figures.@abstract
{
    public interface IFigure
    {
        public double Area { get; }
        
        public double Perimeter { get; }
        
        public FigureType FigureType { get; }

        public int FigureId { get; }
        public object Title => FigureType.ToString();

        // public Figure(int figureId)
        // {
        //     FigureId = figureId;
        // }

        public string GetTitle()
        {
            return $"{FigureId}:{Title}";
        }
        
        public int GetAnglesCount();

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