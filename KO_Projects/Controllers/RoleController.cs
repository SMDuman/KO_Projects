using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KO_Projects.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "RequreManager")]
        public IActionResult Manager()
        {
            return View();
        }

        [Authorize(Policy = "RequreAdmin")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
