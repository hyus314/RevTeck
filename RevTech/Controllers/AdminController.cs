using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RevTech.App.Extensions;
using System.Data;

namespace RevTech.App.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        [Authorize(Roles = "User")]
        [HttpPost]
        public IActionResult Register(string inputPassword)
        {
            var userId = this.User.GetId();



            return View();
        }
    }
}
