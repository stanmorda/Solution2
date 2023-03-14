using System;

namespace ConsoleApp1
{
    class Program
    {
        // private static int count = 0;
        //
        // static int GetClickCount()
        // {
        //     return count++;
        // }
        
        
        
        static void Main(string[] args)
        {
            
            
            // The operators include the unary logical negation (!),
            // and the binary conditional logical AND (&&) and OR (||).



            //11001

            //Console.WriteLine();

            bool b = true;
            
            do
            {
                Console.WriteLine("Введите целое число:");

                string read = Console.ReadLine();

                bool result = Int32.TryParse(read, out int i);

                if (result)
                {
                    i += 99;

                    Console.WriteLine($"Ваше число: {i}");

                    b = false;
                }

                Console.WriteLine("Некорректные данные.");

            } while (b);
         
            
            //int i = Convert.ToInt32(read);
           

            
            
            // НЕ(ложь) И истина
            // истина И истина
            // истина

            // Console.WriteLine(GetClickCount()); 
            // Console.WriteLine(GetClickCount());
            // Console.WriteLine(GetClickCount());

            // int b = 5;
            //
            // //i = i + 4;
            // float c = b * a;
            //int d = a - b;
           
            //Console.WriteLine(d);
            
            // //- 2,147,483,648 ... 2,147,483,647
            //
            // // -1.79769313486232e308 ... -1.79769313486232e308
           
            //
            // //-3.402823e38 ... 3.402823e38
            // float f;
            //
            // string s;
            //
            // // true - false
            // bool b;
            
            
            

            
            Console.ReadLine();
        }
    }
}