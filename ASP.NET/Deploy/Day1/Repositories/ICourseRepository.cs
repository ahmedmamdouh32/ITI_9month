using Day1.Entities;

namespace Day1.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IQueryable<Course> GetByCrsName(string email);
    }
}
