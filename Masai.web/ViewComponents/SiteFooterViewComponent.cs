namespace Masai.web.ViewComponents;
using Microsoft.AspNetCore.Mvc;

public class SiteFooterViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteFooter");
    }
}