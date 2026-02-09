using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Entities
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageSrc { get; set; }
        public int? Salary {  get; set; }
        public string? Address { set; get; }


        [ForeignKey("Department")]
        public int DepartmentId { set; get; }

        [ForeignKey("Course")]
        public int CourseId { set; get; }

        public virtual Department? department { set; get; }
        public virtual Course? course { set; get; }
    }
}
