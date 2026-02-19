using Day1.Entities;
using Microsoft.EntityFrameworkCore;
namespace Day1.Repositories
{
    public class InstructorRepository : IinstructorRepository
    {
        public MVCContext DbContext { get; }

        public InstructorRepository(MVCContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public void Add(Instructor t)
        {
            DbContext.Add(t);
        }

        public void Delete(int Id)
        {
            Instructor instructor = GetById(Id);
            DbContext.Instructors.Remove(instructor);
        }

        public IQueryable<Instructor> GetAll()
        {
            return DbContext.Instructors.Include(i => i.department).Include(i => i.course);
        }

        public Instructor GetById(int Id)
        {
            return DbContext.Instructors.Where(i => i.Id == Id).Include(i => i.course).Include(i => i.department).SingleOrDefault();
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public void Update(Instructor t)
        {
            Instructor instructor = GetById(t.Id);
            instructor.Name = t.Name;
            instructor.Address = t.Address;
            instructor.CourseId = t.CourseId;
            instructor.course = t.course;
            instructor.Salary = t.Salary;
            instructor.ImageSrc = t.ImageSrc;
            instructor.department = t.department;
            instructor.DepartmentId = t.DepartmentId;
        }
    }
}
