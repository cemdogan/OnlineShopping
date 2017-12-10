using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using OnlineShopping.Northwind.MvcWebUI.Models;
using OnlineShopping.Northwind.MvcWebUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Northwind.MvcWebUI.ViewComponents
{
    public class CartSummartViewComponent:ViewComponent
    {
        ICartSessionService _cartSessionService;
        public CartSummartViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };

            return View("/Views/Components/CartSummart/Default.cshtml", model);
        }
    }
}
