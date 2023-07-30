using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace RevTech.App.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
    }
}
