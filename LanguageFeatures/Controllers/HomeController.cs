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
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            return View("Index", new string[] { $"Razem koszyk: {cartTotal:C2}", $"Razem tablica: {arrayTotal:C2}" });
        }
    }
}
