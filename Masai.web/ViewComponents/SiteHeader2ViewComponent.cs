using Microsoft.AspNetCore.Mvc;

namespace Masai.web.ViewComponents;

public class SiteHeader2ViewComponent: ViewComponent
{ 
  public IViewComponentResult Invoke()
   {
      return View("SiteHeader2");
   }
}