using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductCard
    {
        public List<Product> Items { get; }


       // public delegate void Action<in T>(T obj);
       // public delegate void NotifyAddedProduct(Product product);
       // public delegate void NotifyOfSalePercent(decimal sale, decimal summOfSale);
        

        private readonly Action<Product> _notifyAddedProduct;
        private readonly Action<decimal, decimal> _notifyOfSalePercent;
        private readonly Func<decimal, decimal> _calculateSaleFunc;
        private readonly Predicate<decimal> _presentGift;


        public event EventHandler<ProductAddEventArgs> ProductAddedEvent;
        
        public void OnProductAddedEvent(Product addedProduct)
        {
            ProductAddedEvent?.Invoke(this, new ProductAddEventArgs(addedProduct));
        }
        
        public ProductCard(Action<Product> notifyAddedProduct, Action<decimal, decimal> notifyOfSalePercent, Func<decimal, decimal> calculateSaleFunc, Predicate<decimal> presentGift)
        {
            Items = new List<Product>();
            _notifyAddedProduct = notifyAddedProduct;
            _notifyOfSalePercent = notifyOfSalePercent;
            _calculateSaleFunc = calculateSaleFunc;
            _presentGift = presentGift;
        }
        
        public void AddProduct(Product product)
        {   
            Items.Add(product);
            OnProductAddedEvent(product);
            _notifyAddedProduct(product);
        }

        public void AddProducts(params Product[] products)
        {
            foreach (var product in products)
            {
                AddProduct(product);
            }
        }

        public decimal GetTotalSumm()
        {
            decimal summ = 0;
            foreach (var product in Items)
            {
                summ += product.Price;
            }

            if (_presentGift(summ))
            {
                Console.WriteLine("Подарим подарок!");
            }
            
            decimal sale = _calculateSaleFunc(summ);

            _notifyOfSalePercent(1M-sale, summ*(1M-sale));
            
            return summ * sale;
        }


        public string PrintAllProduct()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var product in Items)
            {
                stringBuilder.AppendLine(product.ToString());
            }

            return stringBuilder.ToString();
        }


 
    }
    
}