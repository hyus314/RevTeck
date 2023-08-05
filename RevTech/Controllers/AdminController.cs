using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RevTech.App.Extensions;
using RevTech.Core.Contracts;
using RevTech.Data.User;
using System.Data;

namespace RevTech.App.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IAdminService service;
        private readonly UserManager<RevTeckUser> userManager;
        public AdminController(IAdminService service, UserManager<RevTeckUser> userManager)
        {
            this.service = service;
            this.userManager = userManager;

        }
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> Register(string inputPassword)
        {
            var userId = this.User.GetId();
            
            var resultSuccess = this.service.PasswordValidation(inputPassword);
            var user = await this.service.GetUserById(userId);
            if (resultSuccess)
            {
                await userManager.AddToRoleAsync(user, "User");
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, error = "Error message here" });
            }
        }
    }
}
