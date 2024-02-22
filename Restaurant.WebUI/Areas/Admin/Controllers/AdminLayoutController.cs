using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}