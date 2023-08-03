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
        public IActionResult Register()
        {
            var userId = this.User.GetId();
            return View();
        }
    }
}
