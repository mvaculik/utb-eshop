using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Web.Models;
using UTB.Eshop.Web.Models.Database;
using UTB.Eshop.Web.Models.Entities;
using UTB.Eshop.Web.Models.Identity;
using UTB.Eshop.Web.Models.ViewModels;

namespace UTB.Eshop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly EshopDbContext eshopDbContext;

        public HomeController(ILogger<HomeController> logger, EshopDbContext eshopDbContext)
        {
            _logger = logger;
            this.eshopDbContext = eshopDbContext;
        }

        public IActionResult Index()
        {
            List<CarouselItem> carouselItems = eshopDbContext.CarouselItems.ToList();
            List<Product> products = eshopDbContext.Products.ToList();


            // add coupons
            List<Coupon> coupons = eshopDbContext.Coupons.ToList();

            List<User> users = eshopDbContext.Users.ToList();
            List<Group> groups = eshopDbContext.Groups.ToList();


            HomeIndexViewModel hiVM = new HomeIndexViewModel()
            {
                CarouselItems = carouselItems,
                Products = products,
                Coupons = coupons,
                Users = users,
                Groups = groups
            };
            return View(hiVM);
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
