using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product product)
        {
            return (product?.Price ?? 0) >= 20;
        }

        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray =
            {
                new Product {Name = "Kajak", Price = 275M},
                new Product {Name = "Kamizelka ratunkowa", Price = 48.95M},
                new Product {Name = "Piłka nożna", Price = 19.50M},
                new Product {Name = "Flaga narożna", Price = 34.95M}
            };

            decimal cartTotal = cart.TotalPrices();
            Func<Product, bool> nameFilter = delegate (Product product)
            {
                return product?.Name?[0] == 'P';
            };
            decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();
            return View("Index", new string[] { $"Razem według nazwy: {nameFilterTotal:C2}", $"Razem według wartości: {priceFilterTotal:C2}" });
        }
    }
}
