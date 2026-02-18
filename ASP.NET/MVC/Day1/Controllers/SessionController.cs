using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Runtime.CompilerServices;
using Day1.Filters;
namespace Day1.Controllers
{

    [CustomExceptionFilter] //now the filter is made on the whole controller actions
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateSession(int id, string name)
        {
            HttpContext.Session.SetString("name", name);
            HttpContext.Session.SetInt32("id", id);
            return Content("Session Created Successfully");
        }



        public IActionResult getSession()
        {
            int? id = HttpContext.Session.GetInt32("id");
            string? name = HttpContext.Session.GetString("name");
            return Content($"ID : {id}, Name {name}");
        }


        public IActionResult setCookie(int id, string name)
        {
            //Session Cookie
            HttpContext.Response.Cookies.Append("Name", name);
            //Presistent Cookie
            CookieOptions cookie = new CookieOptions();
            cookie.Expires= DateTimeOffset.Now.AddDays(1);
            HttpContext.Response.Cookies.Append("Id", id.ToString(),cookie);

            return Content("Cookie created");
        }

        public IActionResult getCookie()
        {
            string name = HttpContext.Request.Cookies["Name"];
            return Content(name);
        }

        [CustomExceptionFilter]
        public IActionResult testException()
        {
            throw new Exception("unhandeled exception");
        }

    }
}
