using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestTasks
{
    class Program
    {
        private static object _sync = new object();

        static void Main(string[] args)
        {


            
            var task = new Task(PrintTimeAction);
            task.Start();
            
            

            while (true)
            {
                Console.WriteLine("Enter numbers!");

                Console.ReadLine();
                
                lock (_sync)
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                
                    Console.WriteLine($"SUM is : {CalculateSum(a, b)}");
                }

            }
            
            Console.WriteLine("Hello World!");
        }

        private static void PrintTimeAction()
        {
            while (true)
            {
                lock (_sync)
                {
                    Console.WriteLine($"TIME: {DateTime.Now:t}");
                }
                Thread.Sleep(3000);
            }
        }

        private static int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}