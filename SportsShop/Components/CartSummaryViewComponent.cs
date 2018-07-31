using Microsoft.AspNetCore.Mvc;
using SportsShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.Components
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cart)
        {
            this.cart = cart;
        }
       public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
