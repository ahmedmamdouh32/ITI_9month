using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Day1.ViewModel
{
    public class RoleVM
    {
        [Required]
        [Display(Name ="Role Name")]
        public string roleName{ set; get; }
    }
}
