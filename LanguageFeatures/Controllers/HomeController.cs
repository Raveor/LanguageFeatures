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
            List<string> results = new List<string>();
            foreach(Product product in Product.GetProducts())
            {
                string name = product?.Name ?? "<brak>";
                decimal? price = product?.Price ?? 0;
                string relatedName = product?.Related?.Name ?? "<brak>";
                results.Add($"Produkt: {name}, cena: {price}, powiązanie {relatedName}");
            }
            return View(results);
        }
    }
}
