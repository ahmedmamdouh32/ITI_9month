using Day1.Entities;
using Day1.Filters;
using Day1.Repositories;
using Microsoft.AspNetCore.Identity;
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
            //builder.Services.AddControllersWithViews(options =>{
            //    options.Filters.Add(new CustomExceptionFilter()); //now the filter is Global, any action made exception this filter will handle it
            //});
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IinstructorRepository,InstructorRepository>();//register
            builder.Services.AddScoped<ITraineeRepository, TraineeRepository>();//register
            builder.Services.AddScoped<ICourseRepository,CourseRepository>();//register
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();//register


            builder.Services.AddSession(change =>
            {
                change.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            //This code says: "Whenever a controller needs MVCContext, create it automatically and inject it."
            builder.Services.AddDbContext<MVCContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("MVCDB"));
            });


            // 2. Add Identity
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                options =>
                {
                    options.Password.RequiredLength = 4;
                    options.Password.RequireNonAlphanumeric = false;
                } //minimum length
            )
            .AddEntityFrameworkStores<MVCContext>()
            .AddDefaultTokenProviders();


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
            app.UseSession();

            app.UseAuthentication();
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
