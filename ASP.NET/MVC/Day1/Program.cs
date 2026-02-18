using Day1.Entities;
using Day1.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IinstructorRepository,InstructorRepository>();//register
            builder.Services.AddScoped<ITraineeRepository, TraineeRepository>();//register
            builder.Services.AddScoped<ICourseRepository,CourseRepository>();//register
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();//register

            //This code says: "Whenever a controller needs MVCContext, create it automatically and inject it."
            builder.Services.AddDbContext<MVCContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("MVCDB"));
            });




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                //pattern: "{controller=Home}/{action=Index}/{id?}")
                pattern: "{controller=Course}/{action=Index}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
