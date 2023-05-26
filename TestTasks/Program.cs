using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TestTasks
{
    class Program
    {
        private static object _sync = new object();

        static void Main(string[] args)
        {
            // 1st var
            // var task = new Task(PrintTimeAction);
            // task.Start();
            
            // 2nd var
            //var task = Task.Factory.StartNew(PrintTimeAction); // task1
            //Task.Factory.StartNew(PrintRandomNumber); // task2
            
            
            // 3d var
            //var task = Task.Run(PrintRandomNumber);
            
            // 4th var
            //Parallel.Invoke(PrintRandomNumber, PrintTimeAction);


            // var task = new Task<int>(Calc);
            // task.Start();
            // Console.WriteLine($"task result is {task.Result}");

            

            // Parallel.Invoke(LongWork);
            
            // Task.Factory.StartNew(LongWork);

            // var time = Stopwatch.StartNew();
            //
            // var r1 = Task.Factory.StartNew(LongWork1).Result;
            // var r2 = Task.Factory.StartNew(LongWork2).Result;
            //
            // time.Stop();
            //
            // Console.WriteLine($"RESULT is {r1+r2}. TIME is {time.ElapsedMilliseconds}ms");
            
            var time = Stopwatch.StartNew();
            var task1 = Task.Factory.StartNew(LongWork1);
            var task2 = Task.Factory.StartNew(LongWork2);
            
            Task.WaitAll(task1, task2);
            
            time.Stop();
            
            Console.WriteLine($"RESULT is {task1.Result + task2.Result}. TIME is {time.ElapsedMilliseconds}ms");
            
            
            // while (true)
            // {
            //     Console.WriteLine("main thread");
            //     Thread.Sleep(500);
            // }
            
            
            return;
            
            

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


        private static void PrintRandomNumber()
        {
            while (true)
            {
                var random = new Random();
                lock (_sync)
                {
                    Console.WriteLine($"Random number is {random.Next(10)}");
                }
                Thread.Sleep(1000);
            }
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

        private static int Calc()
        {
            return 5 + 4;
        }

        private static int LongWork1()
        {
            Thread.Sleep(2000);
            return Calc();
        }
        
        private static int LongWork2()
        {
            Thread.Sleep(5000);
            return Calc() * Calc()* Calc();
        }
    }
}