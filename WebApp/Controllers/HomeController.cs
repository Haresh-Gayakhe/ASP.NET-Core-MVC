using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller // Name of controller is Home
    {
        public IActionResult Index() // Name of action method is Index
        {
            return View("Index"); // Render the Index view
        }

    }
}
