using System;
using System.Collections.Generic;
using System.Diagnostics;
using Products;
using System.Linq;

namespace ConsoleApp6Array
{
    class Program
    {

        class LinqResult
        {
            public string Title { get; set; }
            public decimal Price { get; set; }

            public LinqResult(string title, decimal price)
            {
                Title = title;
                Price = price;
            }
        }
        
        static void Main(string[] args)
        {

            // void addOrUpdate(Dictionary<int, string> dictionary, int key, string value)
            // {
            //     // dictionary[key] = value;
            //     
            //     if (dictionary.ContainsKey(key))
            //     {
            //         dictionary[key] = value;
            //     }
            //     else
            //     {
            //         dictionary.Add(key, value);
            //     }
            // }

            var milk1 = new Product(100, "Milk");
            
            var milk2 = new Product(100, "Milk");
            
            var pr1 = new Product(80, "1"){IsNew = true};
            var pr2 = new Product(90, "2");

            var pr3 = new Product(70, "3"){IsNew = true};
            var pr4 = new Product(70, "4");

            var pr5 = new Product();
            pr5.Id = 123;

            var card1 = new ProductCard(new List<Product>() { milk1, pr1, pr2 });
            var card2 = new ProductCard(new List<Product>() { milk2, pr3, pr4 });
            var card3 = new ProductCard(new List<Product>() { milk2, pr3, pr4,milk1, pr1, pr2 });

            var listOfCard = new List<ProductCard>() { card1, card2, card3 };

            var newProd = listOfCard
                .SelectMany(x => x.Items)
                .Where(x => x.IsNew == true)
                .ToArray();

            var sum = newProd.Sum(x => x.Price);
            var count = newProd.Count();
            
            // 1. count
            // 2. sum

            Console.WriteLine($"{milk2 == milk2}");
            
            var list = new List<Product>();
            //
            list.Add(milk1);
            list.Add(milk2);
            list.Add(pr1);
            list.Add(pr2);
            list.Add(pr3);
            list.Add(pr4);

            list = list.Skip(400).ToList();
                            
            var newProduct = new List<string>();
            
            foreach (var product in list)
            {
                if (product.IsNew)
                {
                    newProduct.Add(product.Title);
                }
            }
            
            Console.WriteLine("Новые продукты:");
            Console.WriteLine(string.Join(";", newProduct));

            var v = new { Amount = 108, Message = "Hello" };

            var newProductsByLinq = list
                .Where(product => product.IsNew == true)
                .Where(product => product.Price>10)
                .Take(5)
                .Select(product => new LinqResult(product.Title, product.Price))
                .ToArray();
            
            return;
            
            //
            // list.RemoveAll(x => x == milk);
            //
            
            //Console.WriteLine($"{milk == milk1}");

            Dictionary<Product, int> products = new Dictionary<Product, int>();
            products.Add(milk1, 100);
            products.Add(milk2, 0);
            
            // products.Add(milk, 99);
            // if(products.Remove(milk1))
            //     Console.WriteLine("REMOVED");
            //
            // Console.WriteLine($"{milk1.GetHashCode()}");

            return;
            
            Dictionary<string, string> books = new Dictionary<string, string>();

            books["hsgdhghs"] = "sdfsdf";
            
            string value;
            
            
            
            // if (books.ContainsKey(1))
            // {
            //     value = books[1];
            // }
            //
            // books.TryGetValue(1, out value);

            //books[100] = "fsdf";

            // if(books.TryAdd(100, "sdf"))
            //     Console.WriteLine("ADDED");

            // books.Add(1, "aaa");
            // books.Add(999, "bbb");
            // books.Add(-1055, "ccc");
            //
            // if(!books.ContainsKey(-1055))
            //     books.Add(-1055, "balbadflbadlfb");
            //
            // Console.WriteLine(books.Remove(77));

            return;
            // int[] array = new int[1000000000];
            //
            // var sw = Stopwatch.StartNew();
            // for (int i = 0; i < array.Length; i++)
            // {
            //     int item = array[i];
            // }
            // sw.Stop();
            //
            // Console.WriteLine(sw.Elapsed.Milliseconds);
            
            // Stack<int> stack = new Stack<int>();
            //
            // for (int i = 0; i < 10; i++)
            // {
            //     stack.Push(i);
            // }
            //
            //
            // stack.;
            //
            // while (stack.TryPop(out var item))
            // {
            //     Console.Write(item);
            //     Console.Write(" ");
            // }
            //
            return;
            // Queue<int> queue = new Queue<int>();
            // // queue.Enqueue(10);
            // // queue.Enqueue(7);
            // // queue.Enqueue(18);
            //
            // for (int i = 0; i < 10; i++)
            // {
            //     queue.Enqueue(i);
            // }
            //
            //
            // while (queue.TryDequeue(out var item))
            // {
            //     Console.Write(item);
            //     Console.Write(" ");
            // }
            //
            //
            // if (!queue.TryPeek(out int peek))
            // {
            //     Console.WriteLine("Очередь пуста");
            // }

            //
            //
            // queue.

            // Console.WriteLine($"head:{queue.Peek()}");
            //
            // var itm = queue.Dequeue();
            // Console.WriteLine(itm);
            //
            // Console.WriteLine($"head after dequeue:{queue.Peek()}");




            // List<int> list = new List<int>();
            //
            // list.Add(10);
            // list.Add(10);
            // list.Add(8);
            // list.Add(7);
            // list.Add(16);
            //
            // Console.WriteLine(string.Join(";", list));
            //
            // //list.RemoveAll(i => i == 10 || i == 8);
            //
            //
            // Console.WriteLine(string.Join(";", list));

            // void A(int index, int[] array)
            // {
            //     array[index] = array[index] + 1;
            // }
            //
            // int[] array = new int[10];
            //
            // int[] newArray = new int[11];
            // Array.Copy(array, newArray, array.Length);
            //
            // // for (int i = 0; i < array.Length; i++)
            // // {
            // //     array[i] = i;
            // // }
            // //
            //
            // A(2, array);
            // A(2, array);
            // A(2, array);
            // A(2, array);

            // Console.WriteLine("Hello World!");
        }
    }
}