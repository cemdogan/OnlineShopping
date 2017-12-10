using System.Collections.Generic;
using OnlineShopping.Northwind.Entity.Concrete;

namespace OnlineShopping.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}