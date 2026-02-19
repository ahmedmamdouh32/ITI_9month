using Day1.Repositories;
using Day1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Day1.Controllers
{
    public class TraineeController : Controller
    {
        ITraineeRepository traineeRepository;
        public TraineeController(ITraineeRepository trainee)
        {
            traineeRepository = trainee;
        }
        public IActionResult Index()
        {
            return View();
        }

        //root : Trainee\TraineeState\{}\{}
        public IActionResult TraineeState(int Tid, int Cid)
        {
            try
            {
                var traineeCourseDegree = traineeRepository.getTraineeDegree(Tid, Cid);
                return View("TraineeState", traineeCourseDegree);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }


        //url : Trainee/TraineeCoursesState?Tid=2
        [HttpGet]
        
        public IActionResult TraineeCoursesState(int Tid)
        {
            try
            {
                var traineeCourses = traineeRepository.getTraineeCoursesStates(Tid);
                TraineeCoursesStatesVM result = new TraineeCoursesStatesVM();
                if (traineeCourses != null)
                {
                    result.TraineeName = traineeCourses[0].traineeName;
                    foreach (var course in traineeCourses)
                    {
                        CrsNameState courseNameState = new CrsNameState();
                        courseNameState.CrsName = course.courseName;
                        courseNameState.Passed = course.passed;
                        result.CoursesState.Add(courseNameState);
                    }
                }
                return View(result);
            }
            catch
            {
                return NotFound(); 
            }
        }
            

    }
}
