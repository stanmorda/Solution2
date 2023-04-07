﻿using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public class Cube : ThreeDimensionFigure
    {
        private double _a;
        
        public Cube(int figureId, double a) : base(figureId)
        {
            _a = a;
        }

        public override double Area => 6 * _a * _a;
        public override double Perimeter => 8 * _a;
        public override FigureType FigureType => FigureType.Cube;
        
        public override int GetAnglesCount()
        {
            return 8;
        }

        public override double Volume => Math.Pow(_a, 3);
    }
}