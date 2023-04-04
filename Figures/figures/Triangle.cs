﻿using System;

namespace Figures.figures
{
    public class Triangle : Figure
    {
        private double _a, _b, _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double A => _a;

        public double B => _b;

        public double C => _c;

        public override double Area => throw new Exception("Не умею");
        public override double Perimeter => _a + _b + _c;

        public override FigureType FigureType => FigureType.Triangle;

        public override string GetTitle()
        {
            return "Triangle";
        }
    }
}