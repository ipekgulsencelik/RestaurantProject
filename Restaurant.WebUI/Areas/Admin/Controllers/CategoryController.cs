using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}