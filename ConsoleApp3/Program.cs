using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        private static int max;
        
        static void Main(string[] args)
        {
            int[] a = new int[3]{1,2,3};
            
            string ss = GetArrayString(a);
            
            Console.WriteLine(ss);
            
            // int[] b = new int[3]{1,20,3};
            //
            //
             string s = "HELLO";
             
             char g = (char)('s' + 's');


            var p = "213324";

            var arr = new int[] { 234, 4, 4, 44 };

            for (var i = 0; i < arr.Length; i++)
            {
                var curr = arr[i];
            }

            int tt;
            
            // var t = new[]{"g", "g"};
            // string[] vowels1 = { "a", "e", "i", "o", "u" };

            int[] arr1 = { 1, 3, 4 };
            var arr2 = new int[3];
            int[] arr3;


            var d = 1.0f;
            float dd = 1;
            
            
            
            //
            // Console.WriteLine(RemoveByIndex(2, ref s));
            //
            // Console.WriteLine(s);

            // double a = 1;
            // double b = 3;
            //
            //double c = GetSumm(a, b);


            // int[] array = new[] { 1, 4, 3, 5, 77,55 };
            // Print(array);
            // int result = GetSumm(array);
            // Print(array);
            //Print(b);
            
            return;
        }
        static int GetSumm(params int[] array)
        {
            // int s = 0;
            // for (int i = 0; i < array.Length; i++)
            // {
            //     s += array[i];
            // }

            array = new int[] { -100, 3 }; 

            return 1;
        }
        
        // static double GetSumm(double a, double b)
        // {
        //     double c = a+b;
        //     
        //     a -= 100;
        //     b += 100;
        //     
        //     return c;
        // }
        
        static string RemoveByIndex(int index, string s)
        {
            s = s.Substring(0, index) + s.Substring(index + 1, s.Length - index - 1);
            return s;
        }

    

        // -2 -1 -5 -10 
        
        /// <summary>
        ///  Саммараи
        /// </summary>
        /// <param name="array"></param>
        /// <exception cref="ArgumentException">Не работает для пустых массивов</exception>
        static void ChangeMax(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("В пустом массиве не может быть максимального элемента");
            }
            
            
            max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                if (current >= max)
                {
                    max = current;
                }
            }
        }
        
        static string GetArrayString(int[] array)
        {
            string s = string.Empty;
            
            for (int i = 0; i < array.Length; i++)
            {
                s += $"{array[i]}";
                
                if (i != array.Length - 1)
                {
                     s+=",";
                }
            }

            s += Environment.NewLine;

            return s;
        }
        
        static string GetArrayStringFromStringBuilder(int[] array)
        {
            //char c = '5';
            //char[] chars = new char[100];

            
            
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append($"{array[i]}");
                
                if (i != array.Length - 1)
                {
                    sb.Append(",");
                }
            }

            sb.AppendLine();

            return sb.ToString();
        }

        
        
    }
}