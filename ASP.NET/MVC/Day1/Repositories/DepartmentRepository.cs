using Day1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day1.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        MVCContext DbContext;
        public DepartmentRepository(MVCContext _dbContext) {
            DbContext = _dbContext;
        }
        public void Add(Department t)
        {
            DbContext.Departments.Add(t);
        }

        public void Delete(int Id)
        {
            Department dept = DbContext.Departments.Find(Id);
            if (dept != null) {
                DbContext.Departments.Remove(dept);
            }
        }

        public IQueryable<Department> GetAll()
        {
            return DbContext.Departments;
        }

        //public Department GetById(int Id)
        //{
        //    return DbContext.Departments.Find(Id);
        //}

        public Department GetById(int Id)
        {
            return DbContext.Departments.Where(d => d.Id == Id).Include(d => d.Courses).Include(d => d.Trainees).Include(d => d.Instructors).SingleOrDefault();
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public void Update(Department t)
        {
            Department dept = GetById(t.Id);
            dept.Name= t.Name;
            dept.ManagerName = t.ManagerName;
            dept.ManagerName= t.ManagerName;
            dept.Courses = t.Courses;
            dept.Trainees = t.Trainees;
            dept.Instructors = t.Instructors;
        }

       
    }
}
