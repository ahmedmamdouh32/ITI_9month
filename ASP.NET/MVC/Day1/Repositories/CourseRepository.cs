using Day1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day1.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public MVCContext DbContext;
        public CourseRepository(MVCContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public void Add(Course t)
        {
            DbContext.Courses.Add(t);
        }

        public Course GetById(int Id)
        {
            return DbContext.Courses.Where(c => c.Id == Id).Include(c => c.Dept).SingleOrDefault();
        }

        public void Delete(int Id)
        {
            Course course = GetById(Id);
            DbContext.Courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return DbContext.Courses.Include(c=>c.Dept).ToList();
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public void Update(Course t)
        {
            Course course = GetById(t.Id);
            course.minDegree = t.minDegree;
            course.Degree = t.Degree;
            course.Duration = t.Duration;
            course.DepartmentId = t.DepartmentId;
            course.Name = t.Name;
        }
    }
}
