using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Northwind.Entity.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
