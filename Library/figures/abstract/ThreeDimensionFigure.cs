namespace Library.figures.@abstract
{
    public abstract class ThreeDimensionFigure : Figure
    {
        protected ThreeDimensionFigure(int figureId) : base(figureId)
        {
        }
        
        public abstract double Volume { get; }
    }
}