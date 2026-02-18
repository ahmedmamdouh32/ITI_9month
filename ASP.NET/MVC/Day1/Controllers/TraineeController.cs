using Day1.Repositories;
using Day1.ViewModel;
using Microsoft.AspNetCore.Mvc;

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
    }
}
