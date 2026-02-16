using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Entities
{
    public class crsResult
    {
        [Key]
        public int Id { get; set; }

        public int? degree { get; set; }

        [ForeignKey("Course")]
        public int CourseId { set; get; }


        [ForeignKey("Trainee")]
        public int TraineeId { set; get; }


        public virtual Trainee? trainee{set;get;}
        public virtual Course? course{set;get;}

    }
}
