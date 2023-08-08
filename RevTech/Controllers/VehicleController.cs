using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RevTech.App.Extensions;
using RevTech.Core.Contracts;

namespace RevTech.App.Controllers
{
    [Authorize]
    public class VehicleController : Controller
    {
        private readonly IVehicleService service;
        public VehicleController(IVehicleService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Select(string userId)
        {
            var user = await this.service.GetUserWithManufacturersAsync(userId);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetModelsByManufacturer(int manufacturerId)
        {
            var models = await this.service.GetModelsByManufacturerIdAsync(manufacturerId);

            return Json(models);
        }

        [HttpGet]
        public async Task<IActionResult> GetEnginesByModel(int carModelId)
        {
            var engines = await this.service.GetEnginesByModelIdAsync(carModelId);

            return Json(engines);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarModels()
        {
            var models = await this.service.GetAllCarModelsAsync();
            return Json(models);
        }
    }
}
