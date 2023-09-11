namespace RevTech.App.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using RevTech.Data.User;
    [Authorize]
    public class PaymentController : Controller
    {
        private readonly UserManager<RevTeckUser> userManager;

        public PaymentController(UserManager<RevTeckUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index(string configurationId)
        {
            var user = await this.userManager.GetUserAsync(User);
            return View();
        }
    }
}
