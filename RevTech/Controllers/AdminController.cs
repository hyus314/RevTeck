using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RevTech.App.Extensions;
using RevTech.Core.Contracts;
using System.Data;

namespace RevTech.App.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IAdminService service;
        public AdminController(IAdminService service)
        {
            this.service = service;
        }
        [Authorize(Roles = "User")]
        [HttpPost]
        public IActionResult Register(string inputPassword)
        {
            var userId = this.User.GetId();

            var resultSuccess = this.service.PasswordValidation(inputPassword);

            return View();
        }
    }
}
