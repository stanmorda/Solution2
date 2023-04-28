using System;
using System.Collections.Generic;
using System.Linq;
using Products;

namespace ConsoleApp6Array
{
    public static class LinqExstensions
    {
        public static IEnumerable<Product> IsNull(this IEnumerable<Product> products)
        {
            if (!products.Any())
                throw new ArgumentNullException();
            return products;
        }
    }
}