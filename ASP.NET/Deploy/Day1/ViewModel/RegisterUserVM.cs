using System.ComponentModel.DataAnnotations;

namespace Day1.ViewModel
{
    public class RegisterUserVM
    {

        public string Username { set; get; }

        [DataType(DataType.Password)]
        public string Password { set; get; }

    
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { set; get; }


        public string? Email { set; get; }
    }
}
