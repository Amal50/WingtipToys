using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WingtipToys.Application.Products.Queries;
using WingtipToys.Web.Mvc.Models;

namespace WingtipToys.Web.Mvc.Controllers
{
    public class HomeController : BaseMvcController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var productsList = await Mediator.Send(new GetProductsByCategotyIdQuery { CategoryID = 1 });
            var vm = new HomeIndexViewModel
            {
                ProductsList = productsList
            };

            return View(vm);
        }
        public async Task<IActionResult> Search(string searchString)
        {
            var productsList = await Mediator.Send(new SearchProductsByNameOrDescriptionQuery { SearchText = searchString });
            var vm = new HomeIndexViewModel
            {
                ProductsList = productsList
            };

            return View("Index" , vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string searchText)
        {
            var productsList = await Mediator.Send(new SearchProductsByNameOrDescriptionQuery { SearchText = searchText });
            var vm = new HomeIndexViewModel
            {
                ProductsList = productsList
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
