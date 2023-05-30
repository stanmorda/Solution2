using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace RaceInThreads
{
    class Program
    {

        private static  int x;

        private static object _sync = new object();

        private static List<int> _errors = new List<int>();
        
        static void Main(string[] args)
        {
            var taskIncrement = Task.Factory.StartNew(() =>
            {
                var time  = Stopwatch.StartNew();
                while (x<=100000)
                {
                    //lock (_sync)
                    {
                        x++;
                    }
                }
                time.Stop();
                Console.WriteLine($"Errors count is {_errors.Count} {time.ElapsedMilliseconds}ms");
            });

            var taskCheck = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    lock (_sync)
                    {
                        if (x % 2 == 0)
                        {
                            if (x % 2 != 0)
                            {
                                _errors.Add(x);
                            }
                        }
                    }
                }
            });

//     Пусть x=0. Предположим, что выполнение программы происходит в таком порядке:
//
//     Оператор if в потоке 2 проверяет x на чётность.
//         Оператор «x++» в потоке 1 увеличивает x на единицу.
//         Оператор вывода в потоке 2 выводит «x=1», хотя, казалось бы, переменная проверена на чётность.


            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}