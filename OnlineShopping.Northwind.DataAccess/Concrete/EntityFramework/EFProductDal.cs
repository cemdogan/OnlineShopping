using OnlineShopping.Core.DataAccess.EntityFramework;
using OnlineShopping.Northwind.DataAccess.Abstract;
using OnlineShopping.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EFProductDal: EFEntityRepositoryBase<Product, NorthwindContext>,IProductDal
    {
    }
}
