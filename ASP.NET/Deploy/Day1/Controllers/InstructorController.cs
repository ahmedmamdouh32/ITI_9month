using Day1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Day1.ViewModel;
namespace Day1.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //End Point : Instructor/getAll
        public IActionResult getAll() => View("InstructorGetAll", new MVCContext().Instructors.Select(e=>e).Include(e=>e.course).Include(e => e.department).ToList());


        //End Point : Instructor/getInstructorByIndex/index
        public IActionResult getInstructorByIndex(int index) => View("InstructorDetails", new MVCContext().Instructors.Where(i => i.Id == index).Include(i=>i.department).Include(i=>i.course).SingleOrDefault());


        //End Point : Instructor/AddInstructor
        public IActionResult AddInstructor() {
            MVCContext _dbContext = new MVCContext();
            InstructorDeptCrs instVM = new InstructorDeptCrs();
            instVM.course = _dbContext.Courses.Select(c=>c).ToList();
            instVM.department = _dbContext.Departments.Select(d=>d).ToList();
            return View("AddInstructor", instVM);
        }


        //End Point : Instructor/SaveInstructor/instVM
        public IActionResult SaveInstructor(InstructorDeptCrs instVM)
        {
            if (instVM.Name != default)
            {
                Instructor instructor = new Instructor();
                instructor.Id = instVM.Id;
                instructor.Salary = instVM.Salary ?? 0;
                instructor.Name = instVM.Name ?? "Not Found";
                instructor.Address = instVM.Address ?? "Not Found";
                instructor.ImageSrc = instVM.ImageSrc ?? " Not Found";
                instructor.CourseId = instVM.CourseId;
                instructor.DepartmentId = instVM.DepartmentId;
                MVCContext _dbContext =  new MVCContext();
                _dbContext.Instructors.Add(instructor);
                _dbContext.SaveChanges();
                //return View("InstructorGetAll", new MVCContext().Instructors.Select(e => e).Include(e => e.course).Include(e => e.department).ToList());
                return RedirectToAction("getAll", "Instructor");
            }
            else
            {
                MVCContext _dbContext = new MVCContext();
                instVM.course = _dbContext.Courses.ToList();
                instVM.department = _dbContext.Departments.ToList();
                return View("AddInstructor", instVM);
            }
        }
    }
}
