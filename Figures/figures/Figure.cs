namespace Figures.figures
{
    public class Figure
    {
        public virtual double Area { get; }
        
        public virtual double Perimeter { get; }

        public virtual string GetTitle()
        {
            return "Unkown Figure";
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