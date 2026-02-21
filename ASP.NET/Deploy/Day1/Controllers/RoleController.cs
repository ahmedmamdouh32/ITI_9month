using Day1.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Day1.Controllers
{
    public class RoleController : Controller
    {

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            RoleManager = roleManager;
        }
        private readonly RoleManager<IdentityRole> RoleManager;

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleVM role)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await RoleManager.CreateAsync(new IdentityRole() { Name = role.roleName});
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Course");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View("Create",role);
        }
    }
}
