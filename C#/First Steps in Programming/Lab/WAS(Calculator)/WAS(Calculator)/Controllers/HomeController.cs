using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WAS_Calculator_.Models;

namespace WAS_Calculator_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public ActionResult Calculator(int num1, int num2)
        {
            this.ViewBag.num1 = num1;
            this.ViewBag.num2 = num2;
            this.ViewBag.sum = num1 + num2;
            return View("Index");   
        }

    }
}