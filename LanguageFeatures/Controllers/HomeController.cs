﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
 
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));
        
    }
}
