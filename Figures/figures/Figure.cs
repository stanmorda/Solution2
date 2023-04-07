namespace Figures.figures
{
    public class Figure
    {
        public virtual double Area { get; }
        
        public virtual double Perimeter { get; }
        
        public int FigureId { get; }
        public string Title => FigureType.ToString();

        public Figure(int figureId)
        {
            FigureId = figureId;
        }

        public string GetTitle()
        {
            return $"{FigureId}:{Title}";
        }
        
        public virtual FigureType FigureType { get; }
        
        
        
        
    }

    public enum FigureType
    {
        Circle, 
        Triangle, 
        Square
    }

    

   
    
}