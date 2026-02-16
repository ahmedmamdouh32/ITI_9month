using System.ComponentModel.DataAnnotations;
using Day1.Entities;
using Microsoft.EntityFrameworkCore;
namespace Day1.Validators
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        //protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        //{
        //    if (value is string)
        //    {
        //        string name =value.ToString();
        //        MVCContext _dbContext = new MVCContext();
        //        if (_dbContext.Courses.FirstOrDefault(c => c.Name == name) != null)
        //        {
        //            return new ValidationResult("Choose unique name");
        //        }
        //    }
        //    return ValidationResult.Success;
        //}

        public override bool IsValid(object? value)
        {
            if (value is string name)
            {
                MVCContext _dbContext = new MVCContext();
                if (_dbContext.Courses.FirstOrDefault(c => c.Name == name) == null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
