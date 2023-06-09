using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FilesTmp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();

            var drive = drives.First();

            //var directories = Directory.GetDirectories()

            var currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string fileName = "tmpFile.txt";

            await WriteByStream("streamFile.data");

            return;
            
            var array = Enumerable.Range(10, 1000)
                .Select(x=>x.ToString())
                .ToArray();

            //await File.WriteAllLinesAsync(fileName, array);


            //await File.AppendAllTextAsync(fileName, $"{Environment.NewLine}text");
            
            // var stream = CreateFile(fileName);
            // stream.W
            
            //await File.AppendAllTextAsync(fileName, "test123");

            var fileContent = await File.ReadAllLinesAsync(fileName);
            Console.WriteLine(fileContent);
                
            
            //DeleteFile(fileName);
            // foreach (var file in GetAllJsons(currentPath))
            // {
            //     Console.WriteLine(file);
            // }

            return;
            
            try
            {
                var info = new DirectoryInfo(currentPath);
                //var createdDir = info.CreateSubdirectory("TestDir");
                foreach (var directoryInfo in info.GetDirectories())
                {
                    if (directoryInfo.Name == "TestDir")
                    {
                        //directoryInfo.MoveTo();
                        directoryInfo.Delete();
                    }
                }
                // if (createdDir.Exists)
                // {
                //     Console.WriteLine("Директория создана!");
                // }

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Нет прав на создание данной директории.");
            }
            
            // foreach (var directory in directories)
            // {
            //     var info = new DirectoryInfo(directory);
            //     Console.WriteLine($"{info.Name}: {info.CreationTime}");
            //
            //     if (info.Name == "inetpub")
            //     {
            //         
            //     }
            // }
            
            Console.WriteLine("Hello World!");
        }

        private static string[] GetAllJsons(string path)
        {
            var files = Directory.GetFiles(path, "*.dll");
            return files;
        }

        private static FileStream CreateFile(string name)
        {
            var fileInfo = new FileInfo(name);
            if (!fileInfo.Exists)
                return fileInfo.Create();
            return File.Open(name, FileMode.Open);
        }

        private static void DeleteFile(string name)
        {
            // var fileInfo = new FileInfo(name);
            // if(fileInfo.Exists)
            //     fileInfo.Delete();
            
            if(File.Exists(name))
                File.Delete(name);
        }

        private static async Task WriteByStream(string fileName)
        {
            string content = "my super content";
            using (FileStream stream = File.Open(fileName, FileMode.OpenOrCreate))
            {
                var bytes = Encoding.Default.GetBytes(content);
                var myBytes = new byte[] { 19, 54, 23, 4, 5 };

                var buffer = myBytes.Concat(bytes.Concat(myBytes)).ToArray();
                
                await stream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }
    
    
}