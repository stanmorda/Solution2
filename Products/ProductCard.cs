using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductCard
    {
        public List<Product> Items { get; }


        public delegate void NotifyAddedProduct(Product product);
        public delegate void NotifyOfSalePercent(decimal sale, decimal summOfSale);
        

        private readonly NotifyAddedProduct _notifyAddedProduct;
        private readonly NotifyOfSalePercent _notifyOfSalePercent;
        
        public ProductCard(NotifyAddedProduct notifyAddedProduct, NotifyOfSalePercent notifyOfSalePercent)
        {
            Items = new List<Product>();
            _notifyAddedProduct = notifyAddedProduct;
            _notifyOfSalePercent = notifyOfSalePercent;
        }
        public void AddProduct(Product product)
        {   
            Items.Add(product);
            _notifyAddedProduct(product);
        }

        public decimal GetTotalSumm()
        {
            decimal summ = 0;
            foreach (var product in Items)
            {
                summ += product.Price;
            }

            decimal sale = 1M;
            
            if (summ > 1000)
            {
                sale = 0.95M;
            }
            else if (summ > 100)
            {
                sale = 0.975M;
            }
            else if (summ > 25)
            {
                sale =  0.99M;
            }

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