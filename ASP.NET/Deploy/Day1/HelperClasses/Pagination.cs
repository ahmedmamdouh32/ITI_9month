using Day1.Entities;

namespace Day1.HelperClasses
{
    static public class Pagination
    {

        static public IQueryable<Course> GetByPage(this IQueryable<Course> courses, int pageNo, int pageSize)
        {
            return courses.Skip((pageNo - 1) * pageSize).Take(pageSize);
        }
    }
}
