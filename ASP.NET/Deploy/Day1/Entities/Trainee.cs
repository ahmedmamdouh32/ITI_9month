using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Entities
{
    public class Trainee
    {
        [Key]
        public int Id { set; get; }
        [MaxLength(50)]
        public string? Name { set; get; }
        public string? ImageSrc { set; get; }
        public string? Address { set; get; }
        public int? Grade{ set; get; }


        [ForeignKey("Department")]
        public int DepartmentId { set; get; }

        public virtual Department? Dept { set; get; }
        public virtual List<crsResult>? CrsResult { set; get; }
    }
}
