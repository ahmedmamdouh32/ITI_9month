using System.Diagnostics;
using Day1.Models;
using Day1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace Day1.Controllers
{
    public class HomeController : Controller
    {
        List<UserTask> users;
        public HomeController()
        {
            users = new List<UserTask>()
            {
                new UserTask() {userName="Ahmed Mamdouh", Age=25, Country="Egypt", id=1, Email="ahmed@gmail.com", Phone="01289973422"},
                new UserTask() {userName="Farid Salem", Age=24, Country="China", id=2, Email="farid@gmail.com", Phone="01504281983"},
                new UserTask() {userName="Osama Ayman", Age=21, Country="UK", id=3, Email="osama@gmail.com", Phone="01894327864"},
                new UserTask() {userName="Yousef Ramadan", Age=34, Country="France", id=4, Email="yousef@gmail.com", Phone="010922384329"},
                new UserTask() {userName="Sara Esam", Age=30, Country="Morroco", id=5, Email="sara@gmail.com", Phone="0127833940287"},
                new UserTask() {userName="Assem Omar", Age=41, Country="England", id=6, Email="assem@gmail.com", Phone="011829347832"}
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        ///home/users
        public IActionResult Users()
        {
            return Json(users);
        }


        ///home/getUsers?id=
        public IActionResult getUser(int id)
        {
            UserTask result = users.FirstOrDefault(u => u.id == id);
            if(result == null)
            {
                return Content("User Not found");
            }
            else
            {
                return Json(users.FirstOrDefault(u => u.id == id));
            }
        }
    }
}
