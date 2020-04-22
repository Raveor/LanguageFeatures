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
            object[] data = new object[] { 275M, 29.95M, "jabłka", "pomarańcze", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] is decimal d)
                {
                    total += d;
                }
            }
            return View("Index", new string[] { $"Razem: {total:C2}" });
        }
    }
}
