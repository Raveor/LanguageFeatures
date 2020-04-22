using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Wodniarstwo";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }
        public bool NameBeginsWithS => Name?[0] == 'P';

        public Product(bool inStock = true)
        {
            InStock = inStock;
        }

        public static Product[] GetProducts()
        {
            Product kayak = new Product()
            {
                Name = "Kajak",
                Category = "Sporty wodne",
                Price = 275M
            };

            Product lifejacket = new Product
            {
                Name = "Kamizelka ratunkowa",
                Price = 48.95M
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}
