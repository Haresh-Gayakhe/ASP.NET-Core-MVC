using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller // Name of controller is Home
    {
        public string Index() // Name of action method is Index
        {
            return "Hello world from action method";
        }

        public string Error()
        {
            return "I have an error here";
        }
    }
}
