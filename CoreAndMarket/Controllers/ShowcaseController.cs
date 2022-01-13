using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndMarket.Controllers
{
    
        [AllowAnonymous]
    public class ShowcaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.catID = id;
            return View();
        }
    }
}
