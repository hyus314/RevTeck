using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RevTech.App.Extensions;
using RevTech.Core.Contracts;
using RevTech.Data.User;
using RevTech.Data.ViewModels.Admin;
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
            var user = await this.service.GetUserByIdAsync(userId);
            if (resultSuccess)
            {
                await userManager.AddToRoleAsync(user, "Admin");
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, error = "Error message here" });
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Actions()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AddVehicle()
        {
            var model = await this.service.GenerateAddViewModelAsync();
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddVehicle(AddVehicleViewModel model)
        {
            await this.service.AddVehicleAsync(model);
            return View("Actions");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllVehicles()
        {
            var models = await this.service.GenerateAllViewModelsAsync();
            return View(models);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveVehicle(int carModelId)
        {
            await this.service.RemoveCarModelAsync(carModelId);
            return Json(new { redirectUrl = Url.Action("Actions", "Admin") });
        }

        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> EditVehicle(int carModelId)
        {
            var model = await this.service.GenerateEditViewModelAsync(carModelId);
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditVehicle(EditVehicleViewModel model)
        {
            await this.service.EditVehicleAsync(model);

            return RedirectToAction("AllVehicles");
        }
    }
}
