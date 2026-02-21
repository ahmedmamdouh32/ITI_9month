using System.ComponentModel.DataAnnotations;

namespace Day1.ViewModel
{
    public class UserLogin
    {
        [Required]
        public string userName { set; get; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { set; get; }

        public bool RememberMe { set; get; }

    }
}
