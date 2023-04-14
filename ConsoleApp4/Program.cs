using System;
using System.IO;
using System.Runtime.Serialization;

namespace ConsoleApp4
{
    class Program
    {

        class MoreThan100Exception : Exception
        {
            public MoreThan100Exception()
            {
            }

            protected MoreThan100Exception(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }

            public MoreThan100Exception(string message) : base(message)
            {
            }

            public MoreThan100Exception(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
        
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("b == 0");
            }

            if (a > 100 || b > 100)
            {
                throw new MoreThan100Exception("Не умеем делить числа больше 100");
            }

            return a / b;
        }
        
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

            try
            {
                var d1 = Convert.ToDouble(s1);
                var d2 = Convert.ToDouble(s2);

                var result = Divide(d1, d2);
                Console.WriteLine($"Result: {result:N1}");
            }
            finally
            {
                s1 = "";
                s2 = "";
                Console.WriteLine("FINALLY");
            }
            
            // {
            //     Console.WriteLine("Деление на ноль запрещено!");
            // }
            // catch (ArgumentException exception)
            // {
            //     Console.WriteLine(exception.Message);
            //     Console.WriteLine(exception.StackTrace);
            // }

            return;
            // var r = Format<int>(1, 4);
            // var r1 = Format<float>(1f, 4f);
            // var r2 = Format<string>("bla", "bla");
            //
            // Console.WriteLine(r);
            // Console.WriteLine(r1);
            // Console.WriteLine(r2);
            
            // string[] states = new[] { "red", "yellow", "green" };
            // string actualState = states[1];
            //
            // switch (actualState)
            // {
            //     case "red":
            //         break;
            // }
            //

            //
            // float f = 1.5f;
            // int i = (int)f;
            //
            // int g = 1;
            // float j = g;

            int j = 0;
            
            for (int i = 0; i < 10; i++)
            {
                j++;
            }
            
            // i
            
            for (int i = 0; i < 10; i++)
            {
                j--;
            }

            
            if (true)
            {
                int h = 0;
                h -= 10;
            }
            else
            {
                if (false)
                {
                    int h = 0;
                    h *= 10;
                }
                else
                {
                    
                }
            }
            
            
            int intState = Convert.ToInt32(Console.ReadLine());
            ColorState actualState = (ColorState)intState;
           
            actualState = ColorState.Yellow;
            actualState = ColorState.Green;
            
            Console.WriteLine(actualState);


            // string s = Console.ReadLine();
            // if (Enum.TryParse(typeof(ColorState), s, true, out object actualState))
            // {
            //     Console.WriteLine($"Converted: {actualState}");
            // }
            // else
            // {
            //     Console.WriteLine($"FAIL");
            // }

            // string task1Result = Task1(1, "2ssdfsd");
            //
            // var task2Result = SummaAndRaznots(500, 600);
            //
            // Print(task1Result, "Среднее");
            //
            // Print(task2Result.Item1, "Сумма");
            // Print(task2Result.Item2, "Разность");
            // Print(task2Result.Item3, "Конкатенация чисел");

        }
        enum ColorState
        {
            Red=10, 
            Yellow=2,
            Green=3
        }

        // enum ColorState
        // {
        //     Red=1, 
        //     Yellow=2,
        //     Green=3
        // }
        
        
  
        

        // 1 = 1,
        // 2 = 1*2,
        // 3 = 1*2*3 = 6,
        // 4 = 1*2*3*4 = 24,
        // 5 = 1*2*3*4*5 = 120
        //
        // const factorial = (n) => {
        //     if (n === 0) {
        //         return 1;
        //     }
        //     else {
        //         return n * factorial(n - 1);
        //     }
        // }
        //
        // const answer = factorial(3);

        
        // 1. n=4, Factorial(3) * 4;
        // 2. n=3, Factorial(2) * 3;
        // 3. n=2, Factorial(1) * 2;
        // 4. n=1, Factorial(0) * 1;
        // 5. n=0 0, 1;

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            else
            {
                return Factorial(n - 1) * n;
            }
        }


  
        
        static (double, double, string) SummaAndRaznots(double a, double b)
        {
            double c = a+b;
            double d = a-b;
            return (c, d, $"{c}-{d}");
        }

        static double Avg(int[] array)
        {
            return -1.5;
        }
        
        static void Print(object s, string comment = null)
        {
            if (string.IsNullOrEmpty(comment))
            {
                Console.WriteLine($"{s}");
            }
            else
            {
                Console.WriteLine($"{comment}: {s}");
            }
        }

        
        static string Task1(int index, string s)
        {
            s = s.Substring(0, index) + s.Substring(index + 1, s.Length - index - 1);
            return s;
        }

    



        

    }
}