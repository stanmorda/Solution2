using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // создать новый массив из положительных элементов 1ого массива
            
            
            Console.WriteLine("Введите размер массив");
            int count = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[count];
            int[] positiveArray = new int[count];
            
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < count; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int index = 0;
            
            for (int i = 0; i < count; i++)
            {
                int current = array[i];
                if (current > 0)
                {
                    positiveArray[index++] = current;
                    
                    // positiveArray[index] = array[i];
                    // index++;
                }
            }
            

            Console.ReadLine();
        }
    }
}