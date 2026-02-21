using Day1.Entities;
using Day1.Repositories;
using Day1.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace Day1.Controllers
{
    public class InstructorController : Controller
    {
        IinstructorRepository instructorRepository;
        ICourseRepository courseRepository;
        IDepartmentRepository departmentRepository;
        public InstructorController(IinstructorRepository InsRepo, ICourseRepository CrsRepo, IDepartmentRepository DeptRepo)
        {
            instructorRepository = InsRepo;
            courseRepository = CrsRepo;
            departmentRepository = DeptRepo;
        }
        public IActionResult Index()
        {
            return View();
        }


        //End Point : Instructor/getAll
        [Authorize]
        public IActionResult getAll()
        {
           return View("InstructorGetAll", instructorRepository.GetAll().ToList());
        }


        //End Point : Instructor/getInstructorByIndex/index
        public IActionResult getInstructorByIndex(int index)
        {
            return View("InstructorDetails", instructorRepository.GetById(index));
        }


        //End Point : Instructor/AddInstructor
        public IActionResult AddInstructor() {
            InstructorDeptCrs instVM = new InstructorDeptCrs();
            instVM.coursesList = new SelectList(courseRepository.GetAll(), "Id", "Name");
            instVM.departmentList = new SelectList(departmentRepository.GetAll(), "Id", "Name");
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
                instructorRepository.Add(instructor);
                instructorRepository.Save();
                return RedirectToAction("getAll", "Instructor");
            }
            else
            {
                instVM.coursesList = new SelectList(courseRepository.GetAll(), "Id", "Name");
                instVM.departmentList = new SelectList(departmentRepository.GetAll(), "Id", "Name");
                return View("AddInstructor", instVM);
            }
        }
    }
}
