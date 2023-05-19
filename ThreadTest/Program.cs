using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Library.figures;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateThreadMethodOne();

            // CreateThreadMethodTwo();

            var figures = new List<Cube>();
            
            foreach (var i in Enumerable.Range(1, 100))
            {
                figures.Add(new Cube(i, i));
            }

            // TODO: распараллель это! долго считает
            // var sum = figures
            //     .Select(x => x.Volume)
            //     .Sum();

            double summ1 = 0;
            double summ2 = 0;

            bool finished1 = false;
            bool finished2 = false;

            AutoResetEvent flag1 = new AutoResetEvent(false);
            AutoResetEvent flag2 = new AutoResetEvent(false);
            
            Console.WriteLine(Environment.ProcessorCount);
            
            var thread1 = new Thread(o =>
            {
                summ1 = figures
                    .Take(figures.Count / 2)
                    .Select(x => x.Volume)
                    .Sum();
                //finished1 = true;
                flag1.Set();
            });
            
            var thread2 = new Thread(o =>
            {
                summ2 = figures
                    .TakeLast(figures.Count / 2)
                    .Select(x => x.Volume)
                    .Sum();
               // finished2 = true;
                flag2.Set();
            });
                
            thread1.Start();
            thread2.Start();

            if (WaitHandle.WaitAll(new[] { flag1, flag2 }, TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine($"Result: {summ1 + summ2}");
            }
            else
            {
                Console.WriteLine($"Не удалось произвести расчеты.");
            }
            
            // while (!finished1 || !finished2)
            // {
            //     Thread.Sleep(TimeSpan.FromMilliseconds(10));
            // }
            
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            
           

            Console.ReadLine();
        }

        private static void CreateThreadMethodTwo()
        {
            ThreadPool.QueueUserWorkItem(state => { Console.WriteLine("pool"); });
        }


        private static void CreateThreadMethodOne()
        {
            var threadDelegate = new ThreadStart(DoWork1);
            var t1 = new Thread(threadDelegate);
            t1.Name = "#1";
            t1.Start();

            var t2 = new Thread(DoWork2);
            t2.Name = "#2";
            t2.Start();
        }

        private static void DoWork1()
        {
            Console.WriteLine("start thread 1");
        }
        
        private static void DoWork2(object obj)
        {
            Console.WriteLine("start thread 2");
        }
    }
}