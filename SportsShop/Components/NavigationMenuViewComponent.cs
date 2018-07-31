using Microsoft.AspNetCore.Mvc;
using SportsShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products.Select(x=>x.Category).Distinct().OrderBy(x=>x));
        }
    }
}
