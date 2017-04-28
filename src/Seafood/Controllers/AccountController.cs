using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Seafood.Models;
using Seafood.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Seafood.Controllers
{
    public class AccountController : Controller
    {
        public ApplicationDbContext _db;
        public UserManager<ApplicationUser> _userManager;
        public SignInManager<ApplicationUser> _signInManager;

        public AccountController (ApplicationDbContext db, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _db = db;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var content = _db.Infos.FirstOrDefault(info => info.Id == 1);
            return View(content);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            var user = new ApplicationUser { UserName = register.Email };
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Please re-enter";
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Please re-enter";
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Info info)
        {
            var content = _db.Infos.FirstOrDefault(infos => infos.Id == 1);
            _db.Infos.Attach(content);
            content.Title = info.Title;
            content.About = info.About;
            content.MainImage = info.MainImage;
            _db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}
