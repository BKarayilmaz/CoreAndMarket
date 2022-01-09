using CoreAndMarket.Data;
using CoreAndMarket.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndMarket.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult VisualizeProductResult()
        {
            return Json(ProductList());
        }
        public List<Class2> ProductList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
                cs2 = c.Products.Select(x => new Class2
                {
                    productname = x.ProductName,
                    stock = x.Stock
                }).ToList();
            return cs2;
        }

        //Statistic
        //    Total Category Count
        //    Total Category Count
        //    Sum Product Count
        //    Drink Count
        //    Fruit Count
        //    Maximum Stock Product Name
        //    Minumum Stock Prodcut Name
        //    Product Average Price
        //    Product Average Price
        
    }
}
