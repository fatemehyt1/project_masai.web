using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Masai.web.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }


}