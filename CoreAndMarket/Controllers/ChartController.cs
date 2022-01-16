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
        Context c = new Context();
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


        public IActionResult Statistics()
        {
            //Total Category Count
            var value1 = c.Categories.Count();
            ViewBag.v1 = value1;
            //Total Product Count
            var value2 = c.Products.Count();
            ViewBag.v2 = value2;
            //Maximum Stock Product Name
            var value3 = c.Products.Where(x => x.Stock == c.Products.Max(y => y.Stock)).Select(z => z.ProductName).FirstOrDefault();
            ViewBag.v3 = value3;
            //Minumum Stock Prodcut Name
            var value4 = c.Products.Where(x => x.Stock == c.Products.Min(y => y.Stock)).Select(z => z.ProductName).FirstOrDefault();
            ViewBag.v4 = value4;
            //Total Product For Technology
            var tid = c.Categories.Where(x => x.CategoryName == "Technology").Select(y => y.CategoryID).FirstOrDefault();
            var value5 = c.Products.Where(x=>x.CategoryID==tid).Count();
            ViewBag.v5 = value5;
            //Average Price
            var value6 = c.Products.Average(x => x.Price).ToString("0.00");
            ViewBag.v6 = value6;
            //Sum Product
            var value7 = c.Products.Sum(x=>x.Stock);
            ViewBag.v7 = value7;
            //Total Price Of All Products
            var value8 = c.Products.Sum(x => x.Price);
            ViewBag.v8 = value8;

            //var orderQuery = c.Products.OrderByDescending(x => x.Stock).Select(y => y.ProductName).FirstOrDefault();



            return View();
        }
        //Statistic
        //    Total Category Count
        //    Total Category Count ----
        //    Sum Product Count
        //    Drink Count ----
        //    Fruit Count ----
        //    Maximum Stock Product Name
        //    Minumum Stock Prodcut Name
        //    Product Average Price
        //    Product Average Price

    }
}
