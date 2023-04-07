using System;
using System.IO;

namespace Figures
{
    public interface ILogger
    {
        void Log(string str);
    }


    public class ConsoleLogger : ILogger, IDisposable
    {
        public void Log(string str)
        {
            Console.Write(str);
        }

        public void Dispose()
        {
            Console.WriteLine("END");
        }
    }
    
    public class FileLogger : ILogger, IDisposable
    {
        private readonly string _fileName;
        
        public FileLogger(string fileName)
        {
            _fileName = fileName;
            
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }
        
        public void Log(string str)
        {
            File.WriteAllText(_fileName, str);
        }

        public void Dispose()
        {
            File.WriteAllText(_fileName, "END");
        }
    }
}