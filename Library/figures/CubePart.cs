using Library.figures.@abstract;

namespace Library.figures
{
    public partial class Cube : IThreeDimensionFigure<int>
    {
        public double Perimeter => 8 * _a;
    }
}

