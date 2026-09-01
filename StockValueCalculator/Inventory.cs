using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockValueCalculator
{
    public class Inventory
    {
        private List<IProduct> products = new List<IProduct>();

        public void AddBook(string name, string author, int pages, decimal basePrice)
        {
            products.Add(new Book(name, author, pages, basePrice));
        }
        public void AddCD(string name, string artist, int tracks, decimal basePrice)
        {
            products.Add(new CD(name, artist, tracks, basePrice));
        }

        public decimal TotalStockValue
        {
            get
            {
                decimal total = 0m;
                foreach (var product in products)
                {
                    total += product.PriceIncludingVAT;
                }
                return total;
            }
        }
    }
}
