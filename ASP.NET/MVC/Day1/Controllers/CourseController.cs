using Day1.Entities;
using Day1.Repositories;
using Day1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Day1.Controllers
{
    public class CourseController : Controller
    {       
        ICourseRepository courseRepository;
        IDepartmentRepository departmentRepository;
        public CourseController(ICourseRepository CrsRepo,IDepartmentRepository DeptRepo) //Dependancy Injection
        {
            this.courseRepository = CrsRepo;
            this.departmentRepository = DeptRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConfirmDelete(int id)
        {
            Course course = courseRepository.GetById(id);
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
            var course = courseRepository.GetById(id);

            if (course != null)
            {
                courseRepository.Delete(id); // only remove if found
                courseRepository.Save();
            }
            return RedirectToAction("ShowCourses","Course");
        }

        public IActionResult AddCourse()
        {
            var departments = departmentRepository.GetAll();

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
                courseRepository.Add(c);
                courseRepository.Save();
                return View("Index");
            }
            else
            {
                result.DepartmentList = new SelectList(departmentRepository.GetAll(), "Id","Name");
                return View("AddCourse", result);
            }
        }

        public IActionResult ShowCourses()
        {
            MVCContext _dbContext = new MVCContext();
            List<Course> courses =  courseRepository.GetAll();
            return View(courses);
        }

        public IActionResult DurationDivByThree(int Duration) => Duration %3 == 0 ? Json(true) : Json(false);
        public IActionResult MinLessThanMax(int? Degree,int? minDegree) => minDegree >= Degree ? Json(false) : Json(true);
        
    }
}
