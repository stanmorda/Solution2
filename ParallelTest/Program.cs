using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(1, 100000000).ToList();

            var result = new int[list.Count];


            for (int i = 1; i <= Environment.ProcessorCount*2; i++)
            {
                var parallelOptions = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = i
                };

                var sw = Stopwatch.StartNew();
            
                Parallel.ForEach(list, parallelOptions,
                    item =>
                    {
                        result[item - 1] = item * item;
                    });
            
                sw.Stop();
            
                Console.WriteLine($"COUNT={i}. Time={sw.ElapsedMilliseconds}ms");
            }
            
          
        }
    }
}