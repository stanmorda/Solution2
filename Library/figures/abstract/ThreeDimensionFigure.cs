namespace Library.figures.@abstract
{
    public interface IThreeDimensionFigure<T> : IFigure<T>
    {
        public double Volume { get; }
    }
}