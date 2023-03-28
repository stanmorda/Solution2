using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Factorial(4));

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