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


        static double TOLERANCE = 0.0001;

        static void Main(string[] args)
        {


            double result = 0;
            result += 4;
            result = result / 2;
            result = result * 1.75;
            

            
            // switch
            Console.WriteLine(result);


            string stringRes = string.Empty;
            
            switch (result)
            {
                case >10:
                    stringRes = "sdfgsfdg";
                    break;
                
                case >9:
                    stringRes = "345";
                    break;
                
                case 0:
                    stringRes = "zero";
                    break;
                
                default:
                    stringRes = "default";
                    break;
            }
            
            Console.WriteLine(stringRes);
           
            
            static string GetString(double value) => value switch
            {
                >= 3 and < 6 => "spring",
                >= 6 and < 9 => "summer",
                >= 9 and < 12 => "autumn",
                12 or (>= 1 and < 3) => "winter",
                _ => throw new ArgumentOutOfRangeException("Unknown"),
            };
            
            Console.WriteLine(GetString(result));
            
            
            // if else
            if (result == 10)
            {
                Console.Write("sdfgsfdg");
            }
            else
            {
                if(Math.Abs(result - 3.5) < TOLERANCE)
                {
                    Console.Write("!!!");
                }
                else if (result == 0)
                {
                    Console.Write("zero");
                }
                else
                {
                    Console.Write("default");
                }
            }

          
            
            // do
            // {
            //     Console.WriteLine("Введите целое число:");
            //
            //     string read = Console.ReadLine();
            //
            //     bool result = Int32.TryParse(read, out int i);
            //
            //     if (result)
            //     {
            //         i += 99;
            //
            //         Console.WriteLine($"Ваше число: {i}");
            //
            //         b = false;
            //     }
            //
            //     Console.WriteLine("Некорректные данные.");
            //
            // } while (b);
            //
            
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