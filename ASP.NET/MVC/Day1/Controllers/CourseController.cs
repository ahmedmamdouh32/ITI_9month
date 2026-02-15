using Day1.Entities;
using Day1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Completion;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
namespace Day1.Controllers
{
    public class CourseController : Controller
    {       
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult ConfirmDelete(int id)
        {
            Course course = new MVCContext().Courses.Include(c=>c.Dept).SingleOrDefault(c => c.Id == id);
            CrsIdNameDeparment CourseVM = new CrsIdNameDeparment()
            {
                Id = course.Id,
                Name = course.Name ?? "not found",
                department = course.Dept ?? new Department() { Name="not found"}
            };
            return View("ConfirmDelete",CourseVM);
        }

        public IActionResult DeleteCourse(int id)
        {
            MVCContext _dbContext = new MVCContext();
            var course = _dbContext.Courses.Find(id);

            if (course != null)
            {
                _dbContext.Courses.Remove(course); // only remove if found
                _dbContext.SaveChanges();
            }
            return RedirectToAction("ShowCourses","Course");
        }

        public IActionResult AddCourse()
        {
            MVCContext _dbContext = new MVCContext();

            var departments = _dbContext.Departments.ToList();

            CourseDept vm = new CourseDept()
            {
                DepartmentList = new SelectList(departments, "Id", "Name")
            };
            
            return View(vm);
        }


        public IActionResult SaveCourse(CourseDept result)
        {
            if(ModelState.IsValid == true)
            {
                ModelState.AddModelError("Duration", "30");
                Course c = new Course()
                {
                    Name = result.Name,
                    Degree = result.Degree,
                    minDegree = result.minDegree,
                    Duration = result.Duration,
                    DepartmentId = result.DepartmentId,
                };
                MVCContext _dbContext = new MVCContext();
                _dbContext.Add(c);
                _dbContext.SaveChanges();

                return View("Index");
            }
            else
            {
                MVCContext _dbContext = new MVCContext();
                result.DepartmentList = new SelectList(_dbContext.Departments.ToList(), "Id","Name");
                return View("AddCourse", result);
            }
        }

        public IActionResult ShowCourses()
        {
            MVCContext _dbContext = new MVCContext();
            List<Course> courses = new List<Course>();
            courses = _dbContext.Courses.Include(c => c.Dept).ToList();
            return View(courses);
        }

        public IActionResult DurationDivByThree(int Duration) => Duration %3 == 0 ? Json(false) : Json(true);
        public IActionResult MinLessThanMax(int? Degree,int? minDegree) => minDegree >= Degree ? Json(false) : Json(true);
        
    }
}
