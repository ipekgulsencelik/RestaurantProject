using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutSidebarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}