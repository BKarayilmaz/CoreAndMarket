using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndMarket.Data.Models
{
    public class AddProduct
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IFormFile ImageUrl { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryID { get; set; }
            }
}
