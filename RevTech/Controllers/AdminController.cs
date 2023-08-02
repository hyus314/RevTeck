using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace RevTech.App.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        [Authorize(Roles = "User")]
        public IActionResult RegisterAdmin(string userId)
        {
            return View();
        }
    }
}
