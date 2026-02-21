using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class WelcomeMessage : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated == true)
            {
                return Content($"Welcome Back {User.Identity.Name}");
            }
            return Content("Welcome Back");
        }
    }
}
