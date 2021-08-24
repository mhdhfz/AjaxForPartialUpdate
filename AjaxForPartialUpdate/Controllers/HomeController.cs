using AjaxForPartialUpdate.Infrastructure;
using AjaxForPartialUpdate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxForPartialUpdate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public IActionResult AllTeachers ()
        {
            var teachers = _db.Teachers.OrderBy(t => t.Name).ToList();
            return PartialView("_AllTeachers", teachers);
        }


        [HttpGet]
        public IActionResult AllSchools()
        {
            var schools = _db.Schools.OrderBy(s => s.Name).ToList();
            return PartialView("_AllSchools", schools);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
