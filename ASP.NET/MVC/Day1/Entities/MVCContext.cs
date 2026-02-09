using Microsoft.EntityFrameworkCore;

namespace Day1.Entities
{
    public class MVCContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=AHMED\\SQLEXPRESS;Initial catalog=MVCdb;Integrated Security=true;trust server certificate=true");
        }

        public virtual DbSet<Course> Courses{ get; set; }
        public virtual DbSet<crsResult> crsResults { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors{ get; set; }
        public virtual DbSet<Trainee> Trainees{ get; set; }





    }
}
