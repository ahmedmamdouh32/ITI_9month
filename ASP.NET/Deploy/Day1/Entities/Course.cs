using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Degree { set; get; }
        public int? minDegree {  set; get; }
        public int? Duration { set; get; }
        [MaxLength(200)]
        public string? ImageUrl { set; get; }

        [ForeignKey("Department")]
        public int DepartmentId { set; get; }
        public virtual Department? Dept{ get; set; }
        public virtual List<crsResult>? Results { set; get; }
        public virtual List<Instructor>? Instructors{ set; get; }
    }
}
