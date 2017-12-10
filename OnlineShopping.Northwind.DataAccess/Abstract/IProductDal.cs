using OnlineShopping.Core.DataAccess;
using OnlineShopping.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Northwind.DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
    }
}
