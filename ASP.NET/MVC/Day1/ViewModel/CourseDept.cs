using Day1.Entities;
using Day1.Validators;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.ViewModel
{
    public class CourseDept
    {
        public int Id { get; set; }


        [Display(Name = "Course Name")]
        [UniqueName]
        public string? Name { get; set; }


        public int? Degree { set; get; }


        [Display(Name="Minimum Degree")]
        public int? minDegree { set; get; }


        [Display(Name = "Duration (Hours)")]
        [Required]
        [Range(minimum:6,maximum:60)]
        public int? Duration { set; get; }


        [Display(Name="Select Department")]
        public int DepartmentId { set; get; }


        public SelectList? DepartmentList { get; set; }  
    }
}
