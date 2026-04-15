using System.ComponentModel.DataAnnotations;

namespace Day3.Models
{
    public class Employee
    {

        public int Id { get; set; }

        //[Required(ErrorMessage ="Name should be set !")]
        //[MinLength(3,ErrorMessage ="Too Short Name"), MaxLength(100, ErrorMessage ="Too Long Name")]
        public string Name { get; set; }

        public string ImageUrl { set; get; }

        [DataType(DataType.EmailAddress)]

        public string Email { set; get; }

        public int departmentID { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , ImageUrl : {ImageUrl} , Email : {Email} , DepartmentID : {departmentID}";
        }
    }
}
