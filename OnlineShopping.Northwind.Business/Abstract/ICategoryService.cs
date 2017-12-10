using OnlineShopping.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
