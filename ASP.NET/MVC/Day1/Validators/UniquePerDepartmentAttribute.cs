using Day1.Entities;
using Day1.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace Day1.Validators
{
    public class UniquePerDepartmentAttribute: ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            CourseDept course = (CourseDept)validationContext.ObjectInstance;
            MVCContext _dbContext = new MVCContext();
            var result = _dbContext.Courses.Where(c => c.Name == (string)value && c.DepartmentId == course.DepartmentId && c.Id != course.Id).Any();
            if (result == true) {
                return new ValidationResult("Course name is taken already");
            }
            return ValidationResult.Success;
        }
    }
}
