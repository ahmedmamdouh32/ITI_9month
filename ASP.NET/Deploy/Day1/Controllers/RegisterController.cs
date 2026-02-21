using Day1.Entities;
using Day1.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace Day1.Controllers
{
    public class RegisterController : Controller
    {
        public RegisterController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        private UserManager<ApplicationUser> userManager { get; }
        private SignInManager<ApplicationUser> signInManager { get; }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserVM userData)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = new ApplicationUser()
                {
                    UserName = userData.Username,
                    Email = userData.Email,
                    myProperty = "nothing"
                    //PasswordHash = userData.Password
                };

                IdentityResult result = await userManager.CreateAsync(applicationUser, userData.Password);
                if (result.Succeeded)
                {
                    //create role here
                    result = await userManager.AddToRoleAsync(applicationUser,"Admin");
                    if (result.Succeeded)
                    {
                        //create cookie
                        await signInManager.SignInAsync(applicationUser, false);
                        return RedirectToAction("Index", "Instructor");
                    }
                    ////create cookie
                    //await signInManager.SignInAsync(applicationUser, false);
                    //return RedirectToAction("Index", "Instructor");
                }
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
                
            }
            return View("Register", userData);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLogin userData)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser UserFromDB = await userManager.FindByNameAsync(userData.userName);
                if (UserFromDB != null) {
                    //create cookie
                    bool found = await userManager.CheckPasswordAsync(UserFromDB,userData.Password);
                    if (found)
                    {
                        await signInManager.SignInAsync(UserFromDB,userData.RememberMe);
                        return RedirectToAction("Index","Course");
                    }
                }
                ModelState.AddModelError("","Invalid Username r Password");

            }

            return View("Login",userData);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }


    }
}
