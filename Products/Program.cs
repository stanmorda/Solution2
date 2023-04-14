using System;
using System.IO;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {

            var pr1 = new Product(100, "pr1");
            var pr2 = new Product(99, "pr2");
            var pr3 = new Product(10, "pr3");

            Console.WriteLine("perekrestok");
            var productCardperekrestok = new ProductCard(NotifyPerekrestok, NotifyOfSaleByConsole);
            productCardperekrestok.AddProduct(pr1);
            productCardperekrestok.AddProduct(pr2);
            productCardperekrestok.AddProduct(pr3);
            Console.WriteLine($"Total: {productCardperekrestok.GetTotalSumm():N0}");

            var card2 = new ProductCard(NotifyPerekrestok, NotifyOfSaleByFile);
            Console.WriteLine($"Total: {card2.GetTotalSumm():N0}");

            // Console.WriteLine("DIKSI");
            // var productCardDiksi = new ProductCard(NotifyDiksi, NotifyOfSale);
            // productCardDiksi.AddProduct(pr1);
            // productCardDiksi.AddProduct(pr2);
            // productCardDiksi.AddProduct(pr3);
            //
            // Console.WriteLine("MAGNIT");
            // var productCardMagnit = new ProductCard(NotifyMagnit, NotifyOfSale);
            // productCardMagnit.AddProduct(pr1);

            // Console.WriteLine(productCard.PrintAllProduct());
            
        }

        public static void NotifyPerekrestok(Product product)
        {
            Console.WriteLine($"Added new product: {product}");
        }
        
        public static void NotifyDiksi(Product product)
        {
            Console.WriteLine($"Welcome! Added new product: {product}");
        }
        
        public static void NotifyMagnit(Product product)
        {
            Console.WriteLine($"MAGNIT! Added new product: {product}");
        }

        public static void NotifyOfSaleByConsole(decimal sale, decimal summOfSale)
        {
            Console.WriteLine($"Скидка составила {sale:P} процентов. В деньгах: {summOfSale:N0}");
        }
        
        public static void NotifyOfSaleByFile(decimal sale, decimal summOfSale)
        {
            var message = $"Скидка составила {sale:P} процентов. В деньгах: {summOfSale:N0}";
            File.WriteAllText("log.txt", message);
        }
    }
}