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
            
            var milk3 = new Product(102, "Milk");
            var pr1 = new Product(80, "1"){IsNew = true};
            var pr2 = new Product(80, "2");
            var pr22 = new Product(60, "22");
            var pr23 = new Product(20, "23");
            var pr24 = new Product(80, "24");
            var pr3 = new Product(70, "3"){IsNew = true};
            var pr4 = new Product(70, "4");
            var pr5 = new Product();
            pr5.Id = 123;

            var card1 = new ProductCard(new List<Product>() { milk1, });
            var card2 = new ProductCard(new List<Product>() { milk1 });

            var linq = card1.Items.Intersect(card2.Items).ToArray();
            
            var card3 = new ProductCard(new List<Product>() { milk2, pr3, pr4,milk1, pr1, pr2 });

            var listOfCard = new List<ProductCard>() { card1, card2, card3 };

            
            
            // Except: возвращает разность двух коллекций, то есть те элементы, которые создаются только в одной коллекции
            // Union: объединяет две однородные коллекции
            // Intersect: возвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях
            // Concat: объединяет две коллекции
                
                
            var listOfUniqeTitles = listOfCard
                .SelectMany(x => x.Items)
                .Select(x => x.Title)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            // var first = listOfUniqeTitles..First();
            // var last = listOfUniqeTitles.Last();
            
            var groups = listOfCard
                .SelectMany(x => x.Items)
                .GroupBy(x=>x.Title)
                .Select(x => new { Title = x.Key, Count = x.Count()})
                .Where(x=>x.Count>3)
                .ToArray();

            var groups1 = listOfCard
                .SelectMany(x => x.Items)
                .GroupBy(x => x.IsNew)
                .Select(x => new { Title = x.Key ? "NEW" : "OLD", Sum = x.Sum(y => y.Price) })
                .ToArray();
            

            var contains = card1.Items.Contains(milk1);

            
            // 50 < x < 100
            // order by Price
            // "Title"


            var prods = listOfCard
                .SelectMany(x => x.Items)
                .IsNull()
                .Where(x => x.Price > 50 && x.Price < 100)
                .IsNull()
                .OrderBy(x => x.Price)
                .IsNull()
                .Select(x => x.Title)
                .ToArray();

            

            //var2
            var allProdsByLinq = listOfCard.SelectMany(x => x.Items).ToList();
            
            //
            //
            // var items = card1.Items.
            //     .OrderBy(x => x.Price)
            //     .ThenBy(x=>x.Title)
            //     .ToArray();


            // Reverse: располагает элементы в обратном порядке
            // All: определяет, все ли элементы коллекции удовлетворяют определенному условию
            // Any: определяет, удовлетворяет хотя бы один элемент коллекции определенному условию
            // Contains: определяет, содержит ли коллекция определенный элемент
            // Count: подсчитывает количество элементов коллекции, которые удовлетворяют определенному условию
            // Sum: подсчитывает сумму числовых значений в коллекции
            // Average: подсчитывает среднее значение числовых значений в коллекции
            // Min: находит минимальное значение
            // Max: находит максимальное значение
            // OrderBy: упорядочивает элементы по возрастанию
            // OrderByDescending: упорядочивает элементы по убыванию
            // ThenBy: задает дополнительные критерии для упорядочивания элементов возрастанию
            // ThenByDescending: задает дополнительные критерии для упорядочивания элементов по убыванию

            // var sum = newProd.Sum(x => x.Price);
            // var count = newProd.Count();
            //
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