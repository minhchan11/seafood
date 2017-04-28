using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Seafood.Models;
using Seafood.ViewModels;
using Microsoft.AspNetCore.Mvc.ViewFeatures;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Seafood.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var content = _db.Infos.FirstOrDefault(info => info.Id == 1);
            return View(content);
        }

        public IActionResult Mail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Mail(Mail mail)
        {
            _db.Mails.Add(mail);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
