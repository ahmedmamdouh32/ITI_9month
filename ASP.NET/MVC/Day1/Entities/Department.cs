using System.ComponentModel.DataAnnotations;

namespace Day1.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ManagerName { get; set; }


        public virtual List<Trainee>? Trainees { get; set; }
        public virtual List<Course>? Courses {  get; set; }
        public virtual List<Instructor>? Instructors{  get; set; }
    }
}
