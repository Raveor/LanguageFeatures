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
            var products = new[]
            {
                new { Name = "Kajak", Price = 275M },
                new { Name = "Kamizelka ratunkowa", Price = 48.95M },
                new { Name = "Piłka nożna", Price = 19.50M },
                new { Name = "Flaga narożna", Price = 34.95M },
            };
            return View(products.Select(p => p.GetType().Name));
        }
    }
}
