namespace RevTech.App.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using RevTech.Core.Contracts;
    using RevTech.Data.User;
    [Authorize]
    public class PaymentController : Controller
    {
        private readonly IPaymentService service;
        private readonly UserManager<RevTeckUser> userManager;

        public PaymentController(UserManager<RevTeckUser> userManager, IPaymentService service)
        {
            this.userManager = userManager;
            this.service = service;
        }

        public async Task<IActionResult> Index(string configurationId)
        {
            var user = await this.userManager.GetUserAsync(User);

            if (user != null)
            {
                HttpContext.Session.SetString("ConfigurationId", configurationId);
                var model = await this.service.GeneratePaymentViewModelAsync(configurationId, user);
                return View("PayConfiguration", model);
            }

            return NotFound();
        }
        public async Task<IActionResult> GetAllPartsForPayment()
        {
            string? configurationId = HttpContext.Session.GetString("ConfigurationId");
            var model = await this.service.GetAllOrderedPartsForPayment(configurationId!);
            HttpContext.Session.Clear();
            return Json(model);
        }
    }
}
