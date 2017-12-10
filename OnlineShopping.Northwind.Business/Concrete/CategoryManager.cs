using OnlineShopping.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Northwind.Entity.Concrete;
using OnlineShopping.Northwind.DataAccess.Abstract;

namespace OnlineShopping.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
