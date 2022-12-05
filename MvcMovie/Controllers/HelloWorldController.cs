using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}