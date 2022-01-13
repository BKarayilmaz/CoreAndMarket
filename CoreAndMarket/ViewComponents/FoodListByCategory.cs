using CoreAndMarket.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndMarket.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ProductRepository productRepository = new ProductRepository();
            var productList = productRepository.List(x=>x.CategoryID==id); ;
            return View(productList);
        }
    }
}
