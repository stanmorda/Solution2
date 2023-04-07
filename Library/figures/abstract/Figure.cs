namespace Library.figures.@abstract
{
    public abstract class Figure
    {
        public abstract double Area { get; }
        
        public abstract double Perimeter { get; }
        
        public abstract FigureType FigureType { get; }

        public int FigureId { get; }
        public object Title => FigureType.ToString();

        public Figure(int figureId)
        {
            FigureId = figureId;
        }

        public string GetTitle()
        {
            return $"{FigureId}:{Title}";
        }
        
        public abstract int GetAnglesCount();

        public virtual FigureColor GetColor()
        {
            return FigureColor.Black;
        }
        
        public override string ToString()
        {
            return GetTitle();
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