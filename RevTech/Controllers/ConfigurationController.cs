using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using RevTech.Core.Contracts;
using RevTech.App.Extensions;
using RevTech.Data.ViewModels.User;
using Newtonsoft.Json;

namespace RevTech.App.Controllers
{
    [Authorize]
    public class ConfigurationController : Controller
    {
        private readonly IConfigurationService service;
        public ConfigurationController(IConfigurationService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MyConfigurations()
        {
            string userId = this.User.GetId();

            var models = await this.service.GetConfigurationsForUserAsync(userId);

            return View(models);
        }
        [HttpGet]
        public IActionResult Create()
        {
            string userId = this.User.GetId();
            var model = this.service.GenerateUserConfiguration(userId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignVehicleToUser(int engineId, int carModelId)
        {
            var userId = this.User.GetId();
            var model = await this.service.GenerateUserViewModelAsync(engineId, carModelId, userId);

            HttpContext.Session.SetString("UserViewModel", JsonConvert.SerializeObject(model));

            return RedirectToAction("ChooseParts");
        }
        [HttpGet]
        public IActionResult ChooseParts()
        {
            var serializedModel = HttpContext.Session.GetString("UserViewModel");

            if (serializedModel != null)
            {
                var model = JsonConvert.DeserializeObject<UserViewModel>(serializedModel);
                return View("ChooseParts", model);
            }

            return RedirectToAction("Select", "Vehicle");
        }

        [HttpPost]
        public async Task<IActionResult> CreateConfiguration(Dictionary<string, int> selectedParts, int engineId, int carModelId)
        {
            var userId = this.User.GetId();

            await this.service.CreateConfigurationForUserAsync(selectedParts, userId, engineId, carModelId);

            return Json(new { redirectUrl = Url.Action("MyConfigurations", "Configuration") });
        }


        [HttpPost]
        public async Task<IActionResult> Remove(int configurationId)
        {
            string userId = this.User.GetId();

            await this.service.RemoveConfigurationAsync(userId, configurationId);

            return Json(new { redirectUrl = Url.Action("MyConfigurations", "Configuration") });
        }

        [HttpGet]
        public async Task<IActionResult> GetJsonEditModel(string configurationId)
        {
            var modelJson = HttpContext.Session.GetString("UserEditConfigurationViewModel");
            return Json(modelJson);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string configurationId)
        {
            var model = await this.service.GenerateEditViewModelAsync(configurationId);

            var modelAsJson = JsonConvert.SerializeObject(model);
            HttpContext.Session.SetString("UserEditConfigurationViewModel", modelAsJson);


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Dictionary<string, int> selectedParts, string configurationId)
        {
            string userId = this.User.GetId();
            await this.service.EditConfigurationAsync(selectedParts, configurationId, userId);

            return Json(new { redirectUrl = Url.Action("MyConfigurations", "Configuration") });
        }
    }
}
