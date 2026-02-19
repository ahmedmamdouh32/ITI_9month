using Day1.Entities;
using Day1.ViewModel;

namespace Day1.Repositories
{
    public interface ITraineeRepository : IRepository<Trainee>
    {
        TraineeCourseDegree getTraineeDegree(int Tid, int Cid);
        List<TraineeCourseDegree> getTraineeCoursesStates(int Tid);

    }
}
