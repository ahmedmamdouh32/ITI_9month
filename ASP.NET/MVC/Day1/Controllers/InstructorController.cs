using Day1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Day1.Controllers
{
    public class InstructorController : Controller
    {
        MVCContext DbContext = new MVCContext();
        public IActionResult Index()
        {
            return View();
        }


        //End Point : Instructor/getAll
        public IActionResult getAll() => View("InstructorGetAll", DbContext.Instructors.Select(e=>e).Include(e=>e.course).Include(e => e.department).ToList());


        //End Point : Instructor/getInstructorByIndex/index
        public IActionResult getInstructorByIndex(int index) => View("InstructorDetails", DbContext.Instructors.Where(i => i.Id == index).Include(i=>i.department).Include(i=>i.course).SingleOrDefault());


    }
}
