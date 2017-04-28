using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Seafood.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Seafood.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        public ApplicationDbContext _db;
        public UserManager<ApplicationUser> _userManager;

        public RolesController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = _db.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IdentityRole role)
        {
            _db.Roles.Add(role);
            _db.SaveChanges();
            ViewBag.ResultMessage = "Role created successfully";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(string roleId)
        {
            var thisRole = _db.Roles.Where(r => r.Id.Equals(roleId, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            return View(thisRole);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(IdentityRole role)
        {
            try
            {
                var thisRole = _db.Roles.Where(r => r.Id.Equals(role.Id, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
                _db.Roles.Attach(thisRole);
                thisRole.Name = role.Name;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return View(role);
            }
        }

        public IActionResult Delete(string RoleName)
        {
            var thisRole = _db.Roles.Where(r => r.Name.Equals(RoleName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            return View(thisRole);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteRole(string RoleName)
        {
            var thisRole = _db.Roles.Where(r => r.Name.Equals(RoleName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            _db.Roles.Remove(thisRole);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Assign()
        {
            ViewBag.Roles = new SelectList(_db.Roles, "Id", "Name");
            ViewBag.Users = new SelectList(_db.Users, "Id", "UserName");
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddRole(string UserName, string RoleName)
        //{
        //    ApplicationUser user = _db.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        //    var account = new RolesController(_db, _userManager);
        //    //var user = await account._userManager.FindByNameAsync(UserName);
        //    //await account._userManager.AddToRoleAsync(user, RoleName);

        //    ViewBag.ResultMessage = "Role created successfully !";
        //    return View("Assign");
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> GetRoles(string UserName)
        //{
        //    if (!string.IsNullOrWhiteSpace(UserName))
        //    {
        //        var account = new AccountController(_db, _userManager, _signInManager);

        //        ViewBag.RolesForThisUser = await account._userManager.GetRolesAsync(await _userManager.FindByNameAsync(UserName));
        //    }

        //    return View("Assign");
        //}
    }
}
