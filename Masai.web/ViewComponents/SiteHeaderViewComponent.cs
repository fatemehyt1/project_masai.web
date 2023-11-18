using Microsoft.AspNetCore.Mvc;

namespace Masai.web.ViewComponents;

public class SiteHeaderViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteHeader");
    }
}