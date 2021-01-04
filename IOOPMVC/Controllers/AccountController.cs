using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOOPMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IOOPMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginViewModel userModel)
        {
            var user = await _userManager.FindByEmailAsync(userModel.UserEmail);

            if (user != null)
            {
                var signResult = await _signInManager.PasswordSignInAsync(user, userModel.UserPassword, false, false);
                if (signResult.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserLoginViewModel userModel)
        {
            var user = new IdentityUser
            {
                UserName = userModel.UserEmail,
                Email = userModel.UserEmail
            };

            if (user != null)
            {
                var signResult = await _userManager.CreateAsync(user, userModel.UserPassword);
                if (signResult.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }

            return View(userModel);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
