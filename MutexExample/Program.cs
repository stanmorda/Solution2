using System;
using System.Threading;

namespace MutexExample
{
    class Program
    {
        private static Mutex _mutex = null;

        static void Main(string[] args)
        {
            
            const string appName = "MyAppName";
            bool createdNew;

            _mutex = new Mutex(true, appName, out createdNew);
           // _mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                Console.WriteLine(appName + " is already running! Exiting the application.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Continuing with the application");
            Console.ReadKey();
            
        }
    }
}