using CoreAndMarket.Data.Models;
using CoreAndMarket.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreAndMarket.Controllers
{
    public class ProductController : Controller
    {
        Context c = new Context();
        ProductRepository productRepository = new ProductRepository();
        public IActionResult Index(int page=1)
        {
            return View(productRepository.ListT("Category").ToPagedList(page,10));
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.vls = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product pr)
        {
            productRepository.AddT(pr);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var x = productRepository.GetT(id);
            x.IsDeleted = true;
            productRepository.UpdateT(x);
            return RedirectToAction("Index");
        }
        public IActionResult GetProduct(int id)
        {
            var x = productRepository.GetT(id);
            Product p = new Product()
            {
                CategoryID = x.CategoryID,
                Stock = x.Stock,
                Price = x.Price,
                Description=x.Description,
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ImageUrl=x.ImageUrl
            };
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryID.ToString()
                                           }).ToList();
            ViewBag.vls = values;
            return View(p);
        }

        public IActionResult UpdateProduct(Product p)
        {
            var x = productRepository.GetT(p.ProductID);
            x.ProductName = p.ProductName;
            x.Stock = p.Stock;
            x.Price = p.Price;
            x.ImageUrl = p.ImageUrl;
            x.Description = p.Description;
            x.CategoryID = p.CategoryID;

            productRepository.UpdateT(x);
            return RedirectToAction("Index");
        }
    }
}
