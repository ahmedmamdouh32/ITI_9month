using Day1.Entities;
using Day1.ViewModel;

namespace Day1.Repositories
{
    public class TraineeRepository : ITraineeRepository
    {
        MVCContext DbContext;
        public TraineeRepository(MVCContext _dbContext)
        {
            DbContext = _dbContext;
        }
        public void Add(Trainee t)
        {
            if(t != null) DbContext.Add(t);
        }

        public void Delete(int Id)
        {
            Trainee t = GetById(Id);
            DbContext.Trainees.Remove(t);
        }

        public IQueryable<Trainee> GetAll()
        {
            return DbContext.Trainees;
        }

        public Trainee GetById(int Id)
        {
            return DbContext.Trainees.Where(t => t.Id == Id).SingleOrDefault();
        }

        public List<TraineeCourseDegree> getTraineeCoursesStates(int Tid)
        {
            List<TraineeCourseDegree> result = DbContext.crsResults.Where(c => c.TraineeId == Tid)
                .Select(c => new TraineeCourseDegree
                {
                    traineeName = c.trainee.Name,
                    courseName = c.course.Name,
                    TraineeDegree = c.degree,
                    courseMinDegree = c.course.minDegree
                }).ToList();

            foreach(var course in result)
            {
                course.passed = course.courseMinDegree > course.TraineeDegree ? false : true;

            }
            return result;
        }

        public TraineeCourseDegree getTraineeDegree(int Tid, int Cid)
        {
            TraineeCourseDegree? result = DbContext.crsResults.Where(c => c.CourseId == Cid && c.TraineeId == Tid)
                .Select(c => new TraineeCourseDegree
                {
                    traineeName = c.trainee.Name,
                    courseName = c.course.Name,
                    TraineeDegree = c.degree,
                    courseMinDegree = c.course.minDegree
                }).FirstOrDefault();
            result.passed = result.courseMinDegree > result.TraineeDegree ? false : true;
            return result;
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public void Update(Trainee t)
        {
            Trainee trainee = GetById(t.Id);
            trainee.Address = t.Address;
            trainee.CrsResult = t.CrsResult;
            trainee.Dept = t.Dept;
            trainee.DepartmentId = t.DepartmentId;
            trainee.Grade = t.Grade;
        }
    }
}
