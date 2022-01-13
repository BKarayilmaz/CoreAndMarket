using CoreAndMarket.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndMarket.ViewComponents
{
    public class ProductGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ProductRepository productRepository = new ProductRepository();
            var productList = productRepository.ListT();
            return View(productList);
        }
    }
}
