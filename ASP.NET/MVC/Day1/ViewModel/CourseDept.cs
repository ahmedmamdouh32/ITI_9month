using Day1.Entities;
using Day1.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Day1.ViewModel
{
    public class CourseDept
    {
        public int Id { get; set; }


        [MaxLength(25, ErrorMessage ="Limit to 25 letters only")]
        [UniquePerDepartment]
        public string? Name { get; set; }


        [Range(minimum:50,maximum:100)]
        public int? Degree { set; get; }

        [Remote(action:"MinLessThanMax",controller:"Course",AdditionalFields ="Degree",ErrorMessage ="Minimum Degree Should be less than Degree")]
        public int? minDegree { set; get; }


        [Remote(action:"DurationDivByThree",controller:"Course",ErrorMessage ="Value should be divisible by 3")]
        public int? Duration { set; get; }
        [Display(Name ="Insert Image")]
        public string? ImageUrl { set; get; }
        public IFormFile? ImageFile { get; set; }

        public int DepartmentId { set; get; }


        public SelectList? DepartmentList { get; set; }  
    }
}
