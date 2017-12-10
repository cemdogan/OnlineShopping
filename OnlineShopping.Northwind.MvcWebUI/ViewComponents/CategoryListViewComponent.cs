using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using OnlineShopping.Northwind.Business.Abstract;
using OnlineShopping.Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Northwind.MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent :ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll(),
                CurrenCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };

            return View("/Views/Components/CategoryList/Default.cshtml", model);
        }
    }
}
