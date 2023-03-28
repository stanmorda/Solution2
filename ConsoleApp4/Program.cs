using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

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