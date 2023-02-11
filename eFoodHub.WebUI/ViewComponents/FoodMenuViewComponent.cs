using eFoodHub.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFoodHub.WebUI.ViewComponents
{
    public class FoodMenuViewComponent : ViewComponent
    {
        ICatalogService _catalogService;
        public FoodMenuViewComponent(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        public IViewComponentResult Invoke()
        {
            var items = _catalogService.GetItems();
            return View("~/Views/Shared/_FoodMenu.cshtml", items);
        }
    }
}
