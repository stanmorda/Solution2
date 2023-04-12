using System;
using System.Collections.Generic;
using System.Text;
using Library.figures;
using Library.figures.@abstract;

namespace Figures
{
    class Program
    {

        abstract class Obj<T, K> 
        {
            public T Id { get; set; }
            public K Data { get; set; }
            
            public Obj(T id, K data, string name = "fsdf")
            {
                Id = id;
                Data = data;
                Name = name;
            }

            public string Name { get; set; }

            public string Format()
            {
                return Name + $"{Id}";
            }
        }


        class ObjString : Obj<string, string>
        {
            public ObjString(string id, string name = "fsdf") : base(id, name)
            {
            }
        }
        
        class ObjInt : Obj<int, string>
        {
            public ObjInt(int id, string name = "fsdf") : base(id, name)
            {
            }
        }   
        class ObjByte : Obj<byte, double>
        {
            public ObjByte(byte id, string name = "fsdf") : base(id, name)
            {
            }
        }
        
        static void Main(string[] args)
        {

            var obj1 = new ObjByte(1);
            var obj2 = new ObjString("id_1");
            var obj3 = new ObjString("id_2");
            
         //  public class GenericFigure<T> where T : IFigure<string>

           //var figure = new GenericFigure<Circle>(new Circle(1, "id"));

           List<string> listString = new List<string>();
           List<int> listInt = new List<int>();

           List<Circle> listCircles = new List<Circle>();
           // 
            // foreach (var figure in figures)
            // {
            //     Console.WriteLine($"{figure.ToString()} - {figure.GetColor()}");
            // }
            
           //  //var d = new D();
           //  var a = new A();
           //  var b = new B();
           //
           // // var a = new A();
           //  
           //  bool result = b is A;
           //  
           //  Console.WriteLine(result);

            // Circle:5
            // Square:10
            // Triangle:10,4,4

            // List<Figure> figures = new List<Figure>();
            // int number = 0;
            // while (true)
            // {
            //     string str = Console.ReadLine();
            //
            //     if (str == "EXIT")
            //     {
            //         break;
            //     }
            //     
            //     string[] arguments = str.Split(":");
            //     string title = arguments[0];
            //
            //     if (Enum.TryParse(typeof(FigureType), title, true, out var temp))
            //     {
            //         FigureType figureType = (FigureType)temp;
            //         Figure figure = null;
            //         
            //         string[] strValues = arguments[1].Split(",");
            //         double[] values = new double[strValues.Length];
            //         for (int i = 0; i < strValues.Length; i++)
            //         {
            //             values[i] = Convert.ToDouble(strValues[i]);
            //         }
            //         
            //         switch (figureType)
            //         {
            //             case FigureType.Circle:
            //                 figure = new Circle(values[0], number);
            //                 break;
            //             
            //             case FigureType.Square:
            //                 figure = new Square(values[0], number);
            //                 break;
            //             
            //             case FigureType.Triangle:
            //                 figure = new Triangle(values[0],values[1],values[2], number);
            //                 break;
            //             default:
            //                 throw new Exception("Не знаю такую фигуру");
            //         }
            //
            //         number++;
            //         figures.Add(figure);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Не знаю такую фигуру");
            //     }
            // }
            //


            var logger = new FileLogger("log.txt");

            var tr1 = new Triangle<int>(a: 1, b: 2, c: 4, figureId: 99);
            var tr2 = new Triangle<string>(a: 1, b: 2, c: 4, figureId: "string_triangle_1");
            var tr3 = new Triangle<byte>(a: 1, b: 2, c: 4, figureId: 10);
            var tr4 = new Triangle<bool>(a: 1, b: 2, c: 4, figureId: true);

            var circle = new Circle(r: 5, figureId: "_circle_");
            circle.TestMethod();
            
            // var figures = new Triangle<object>[] { tr1, tr3 };
            
            // IFigure[] figures = new IFigure[] { 
            //     new Circle(r: 4, figureId: 1), 
            //     new Square(a: 55, figureId: "square1"), 
            //     new Cube(77, 88),
            //     new Circle(3, 4), 
            //     new Square(33, 5), 
            //     new Triangle(1,5,6,9),
            //     new Cube(88, 9999)
            // };

            
            
            double summ = 0;
            
            // foreach (var figure in figures)
            // {
            //     // if (figure is ThreeDimensionFigure threeDimensionFigure)
            //     // {
            //     //     summ += threeDimensionFigure.Volume;
            //     // } 
            //     logger.Log($"{figure.FigureId}:{figure.Perimeter}");
            //     
            //     summ += figure.Perimeter;
            // }
            
            logger.Dispose();
            
            Console.WriteLine($"Суммарная площадь всех фигур: {summ}");
            
            //
            // Console.WriteLine("Areas.");
            // Console.WriteLine(CalculateAreas(figures));
            //
            // Console.WriteLine("Perimeters.");
            // Console.WriteLine(CalculatePerimeters(figures));
            
        }
        
        // public class A
        // {
        //     protected string S { get; set; }
        //     public int I { get; set; }
        // }
        //
        // public class B : A
        // {
        //     public int K { get; set; }
        //
        //     public void Temp()
        //     {
        //         S = "sdfsdf";
        //     }
        // }
        //
        // public class C : B
        // {
        //     public int G { get; set; }
        //
        // }
        //
        //
        // public class D : C
        // {
        //     public int LL { get; set; }
        //
        // }

        // static string CalculateAreas(List<IFigure> figures)
        // {
        //     StringBuilder sb = new StringBuilder();
        //     foreach (var figure in figures)
        //     {
        //         var str = $"{figure.GetTitle()}:{figure.Area:F1}";
        //         sb.AppendLine(str);
        //     }
        //
        //     return sb.ToString();
        // }
        //
        // static string CalculatePerimeters(List<IFigure> figures)
        // {
        //     StringBuilder sb = new StringBuilder();
        //     foreach (var figure in figures)
        //     {
        //         var str = $"{figure.GetTitle()}:{figure.Perimeter:F1}";
        //         sb.AppendLine(str);
        //     }
        //
        //     return sb.ToString();
        // }
    }
}