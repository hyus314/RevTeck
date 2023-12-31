﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RevTech.App.Extensions;
using RevTech.Core.Contracts;
using RevTech.Data.User;
using RevTech.Data.ViewModels.Admin.Engine;
using RevTech.Data.ViewModels.Admin.Vehicle;
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
                return Json(new { success = false, error = "Wrong Password" });
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
            try
            {
                var model = await this.service.GenerateAddViewModelAsync();
                return View(model);

            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddVehicle(AddVehicleViewModel model)
        {
            try
            {
                await this.service.AddVehicleAsync(model);
                return View("Actions");
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllVehicles()
        {
            try
            {
                var models = await this.service.GenerateAllViewModelsAsync();
                return View(models);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveVehicle(int carModelId)
        {
            try
            {
                await this.service.RemoveCarModelAsync(carModelId);
                return Json(new { redirectUrl = Url.Action("Actions", "Admin") });
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditVehicle(int carModelId)
        {
            try
            {
                var model = await this.service.GenerateEditViewModelAsync(carModelId);
                return View(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditVehicle(EditVehicleViewModel model)
        {
            try
            {
                await this.service.EditVehicleAsync(model);
                return RedirectToAction("AllVehicles");
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddEngine()
        {
            try
            {
                var model = this.service.GenerateAddEngineViewModel();
                return View(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddEngine(AddEngineViewModel model)
        {
            try
            {
                await this.service.AddEngineAsync(model);
                return View("Actions");
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllEngines()
        {
            try
            {
                var models = await this.service.GetAllEnginesAsync();
                return View(models);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddPart()
        {
            try
            {
                var model = this.service.GenerateAddPerformancePartView();
                return View(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetEnginesForPart()
        {
            var models = await this.service.GetAllEnginesAsync();
            return Json(models);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddTurbo([FromBody] Dictionary<string, string> formData)
        {
            await this.service.AddTurboAsync(formData);
            return Json(new { redirectUrl = Url.Action("Actions", "Admin") });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddExhaustKit([FromBody] Dictionary<string, string> formData)
        {
            await this.service.AddExhaustKitAsync(formData);
            return Json(new { redirectUrl = Url.Action("Actions", "Admin") });
        }
    }
}
