using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutScriptPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}