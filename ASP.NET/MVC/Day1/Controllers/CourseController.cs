using Day1.Entities;
using Day1.Repositories;
using Day1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Day1.HelperClasses;
using Microsoft.EntityFrameworkCore;
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

        //public IActionResult SaveCourse(CourseDept result)
        //{
        //    if(ModelState.IsValid == true)
        //    {
        //        ModelState.AddModelError("Duration", "30");
        //        Course c = new Course()
        //        {
        //            Name = result.Name,
        //            Degree = result.Degree,
        //            minDegree = result.minDegree,
        //            Duration = result.Duration,
        //            DepartmentId = result.DepartmentId,
        //        };
        //        courseRepository.Add(c);
        //        courseRepository.Save();
        //        return View("Index");
        //    }
        //    else
        //    {
        //        result.DepartmentList = new SelectList(departmentRepository.GetAll(), "Id","Name");
        //        return View("AddCourse", result);
        //    }
        //}


        [HttpPost]
        public async Task<IActionResult> SaveCourse(CourseDept result)
        {
            if (ModelState.IsValid)
            {
                string imagePath = null;

                // Upload image if exists
                if (result.ImageFile != null)
                {
                    string fileName = Guid.NewGuid().ToString()
                                      + Path.GetExtension(result.ImageFile.FileName);

                    string filePath = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot/images",
                        fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await result.ImageFile.CopyToAsync(stream);
                    }

                    imagePath = "/images/" + fileName;
                }

                Course c = new Course()
                {
                    Name = result.Name,
                    Degree = result.Degree,
                    minDegree = result.minDegree,
                    Duration = result.Duration,
                    DepartmentId = result.DepartmentId,
                    ImageUrl = imagePath   // ← ADD THIS
                };

                courseRepository.Add(c);
                courseRepository.Save();

                return RedirectToAction("Index"); // better than View("Index")
            }

            result.DepartmentList =
                new SelectList(departmentRepository.GetAll(), "Id", "Name");

            return View("AddCourse", result);
        }

        public IActionResult DurationDivByThree(int Duration) => Duration %3 == 0 ? Json(true) : Json(false);

        public IActionResult MinLessThanMax(int? Degree,int? minDegree) => minDegree >= Degree ? Json(false) : Json(true);




        
        public IActionResult ShowCourses(string searchText = "", int page = 1)
        {
            int pageSize = 3;

            IQueryable<Course> query = courseRepository.GetAll().Include(c => c.Dept);

            // Apply search filter
            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(c => c.Name.Contains(searchText));
            }

            int totalItems = query.Count();

            var vm = new CoursePage
            {
                Courses = query.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                pageNumber = page,
                PagesCount = (int)Math.Ceiling((double)totalItems / pageSize),
                SearchText = searchText
            };

            return View(vm);
        }
        

        //public IActionResult SearchCourses(string CourseName)
        //{
        //    CoursePage crsPageVM = new CoursePage();
        //    var query = courseRepository.GetByCrsName(CourseName);
        //    crsPageVM.PagesCount = query.Count()/5;
        //    crsPageVM.Courses = query.ToList();
        //    return View("ShowCourses", crsPageVM);
        //}
    }
}
