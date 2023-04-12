using Library.figures.@abstract;

namespace Library.figures
{
    public class GenericFigure<T> where T : IFigure<string>
    {
        public T Figure { get; set; }

        public GenericFigure(T figure)
        {
            Figure = figure;
        }

    }
}