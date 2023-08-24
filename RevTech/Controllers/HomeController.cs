using Microsoft.AspNetCore.Mvc;
using RevTech.Data;
using RevTech.Data.ViewModels.Errors;
using System.Diagnostics;

namespace RevTech.App.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
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
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View(statusCode.ToString());
            }
            if (statusCode == 401)
            {
                return View(statusCode.ToString());
            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}