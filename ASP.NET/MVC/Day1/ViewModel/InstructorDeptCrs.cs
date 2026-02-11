using Day1.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.ViewModel
{
    public class InstructorDeptCrs
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageSrc { get; set; }
        public int? Salary { get; set; }
        public string? Address { set; get; }

        public int DepartmentId { set; get; }

        public int CourseId { set; get; }

        public List<Department> department { set; get; }
        public List<Course> course { set; get; }
    }
}
