using System;
using System.Collections.Generic;
using System.Text;
using Figures.figures;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Circle:5
            // Square:10
            // Triangle:10,4,4

            List<Figure> figures = new List<Figure>();

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "EXIT")
                {
                    break;
                }
                
                string[] arguments = str.Split(":");
                string title = arguments[0];

                if (Enum.TryParse(typeof(FigureType), title, true, out var temp))
                {
                    FigureType figureType = (FigureType)temp;
                    Figure figure = null;
                    
                    string[] strValues = arguments[1].Split(",");
                    double[] values = new double[strValues.Length];
                    for (int i = 0; i < strValues.Length; i++)
                    {
                        values[i] = Convert.ToDouble(strValues[i]);
                    }
                    
                    switch (figureType)
                    {
                        case FigureType.Circle:
                            figure = new Circle(values[0]);
                            break;
                        
                        case FigureType.Square:
                            figure = new Square(values[0]);
                            break;
                        
                        case FigureType.Triangle:
                            figure = new Triangle(values[0],values[1],values[2]);
                            break;
                        default:
                            throw new Exception("Не знаю такую фигуру");
                    }   
                    
                    figures.Add(figure);
                }
                else
                {
                    Console.WriteLine("Не знаю такую фигуру");
                }
            }
            
            //Figure[] figures = new Figure[] { new Circle(4), new Square(55), new Circle(3), new Square(33) };

            double summ = 0;
            
            foreach (var figure in figures)
            {
                summ += figure.Perimeter;
            }

            Console.WriteLine($"Суммарная площадь всех фигур: {summ}");
            
            
            Console.WriteLine("Areas.");
            Console.WriteLine(CalculateAreas(figures));
            
            Console.WriteLine("Perimeters.");
            Console.WriteLine(CalculatePerimeters(figures));
            
        }

        static string CalculateAreas(List<Figure> figures)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var figure in figures)
            {
                var str = $"{figure.GetTitle()}:{figure.Area:F1}";
                sb.AppendLine(str);
            }

            return sb.ToString();
        }
        
        static string CalculatePerimeters(List<Figure> figures)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var figure in figures)
            {
                var str = $"{figure.GetTitle()}:{figure.Perimeter:F1}";
                sb.AppendLine(str);
            }

            return sb.ToString();
        }
    }
}