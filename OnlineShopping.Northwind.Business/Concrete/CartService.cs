using OnlineShopping.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Northwind.Entity.Concrete;
using System.Linq;

namespace OnlineShopping.Northwind.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            var cartLine = cart.CartLines.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(i => i.Product.ProductId == productId));
        }
    }
}
