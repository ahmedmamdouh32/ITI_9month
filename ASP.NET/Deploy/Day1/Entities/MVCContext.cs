using Microsoft.EntityFrameworkCore;

namespace Day1.Entities
{
    public class MVCContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //"data source=AHMED\\SQLEXPRESS;Initial catalog=MVCdb;Integrated Security=true;trust server certificate=true")
                optionsBuilder.UseSqlServer("Server=db41385.public.databaseasp.net; Database=db41385; User Id=db41385; Password=4b-P?2Nn9Wd!; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
                base.OnConfiguring(optionsBuilder);
            }
        }

        public MVCContext(DbContextOptions<MVCContext> options) : base(options){


        }

        public MVCContext() : base() //left for compatability
        {

        }

        public virtual DbSet<Course> Courses{ get; set; }
        public virtual DbSet<crsResult> crsResults { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors{ get; set; }
        public virtual DbSet<Trainee> Trainees{ get; set; }





    }
}
