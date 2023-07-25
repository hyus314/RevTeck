using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RevTech.Core.Contracts;

namespace RevTech.App.Controllers
{
    [Authorize]
    public class PartsController : Controller
    {
        private readonly IPerformancePartService service;

        public PartsController(IPerformancePartService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> LoadTurbos(int engineId)
        {
            var turbos = await this.service.GetTurbosForEngineAsync(engineId);

            return Json(turbos);
        }

        [HttpGet]
        public async Task<IActionResult> LoadExhaustKits(int engineId, int carModelid)
        {
            var exhaustKits = await this.service.GetExhaustsForModelAndEngineAsync(engineId, carModelid);

            return Json(exhaustKits);
        }

        [HttpGet]
        public async Task<IActionResult> LoadSuperchargers(int engineId)
        {
            var superchargers = await this.service.GetSuperchargersForEngineAsync(engineId);

            return Json(superchargers);
        }

        [HttpGet]
        public async Task<IActionResult> LoadEcuTunings(int engineId)
        {
            var ecus = await this.service.GetECUTuningsForEngineAsync(engineId);

            return Json(ecus);
        }

        [HttpGet]
        public async Task<IActionResult> LoadFuelPumps(int engineId)
        {
            var fuelPumps = await this.service.GetFuelPumpForEngineAsync(engineId);

            return Json(fuelPumps);
        }

        [HttpGet]
        public async Task<IActionResult> LoadInjectorKits(int engineId)
        {
            var injectorKits = await this.service.GetInjectorKitsForEngine(engineId);

            return Json(injectorKits);
        }
        [HttpGet]
        public async Task<IActionResult> LoadOilCoolers(int engineId)
        {
            var oilCoolers = await this.service.GetOilCoolersForEngineAsync(engineId);

            return Json(oilCoolers);
        }

        [HttpGet]
        public async Task<IActionResult> LoadSparkPlugs(int engineId)
        {
            var sparkPlugs = await this.service.GetSparkPlugsForEngineAsync(engineId);

            return Json(sparkPlugs);
        }

        [HttpGet]
        public async Task<IActionResult> LoadTcuTunings()
        {
            var tcuTunings = await this.service.GetTCUTuningsAsync();

            return Json(tcuTunings);
        }

    }
}
