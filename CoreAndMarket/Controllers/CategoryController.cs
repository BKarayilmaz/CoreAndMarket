using CoreAndMarket.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndMarket.Data.Models;
using X.PagedList;

namespace CoreAndMarket.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index(int page = 1)
        {
            return View(categoryRepository.ListT().ToPagedList(page, 10));
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category cat)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCategory");
            }
            categoryRepository.AddT(cat);
            return RedirectToAction("Index");
        }
        public IActionResult GetCategory(int id)
        {
            var x = categoryRepository.GetT(id);
            Category ct = new Category()
            {
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CategoryID = x.CategoryID
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category ct)
        {
            var x = categoryRepository.GetT(ct.CategoryID);
                x.CategoryName = ct.CategoryName;
            x.CategoryDescription = ct.CategoryDescription;
            x.IsDeleted = false;
            categoryRepository.UpdateT(x);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var x = categoryRepository.GetT(id);
            x.IsDeleted = true;
            categoryRepository.UpdateT(x);
            return RedirectToAction("Index");
        }
    }
}
