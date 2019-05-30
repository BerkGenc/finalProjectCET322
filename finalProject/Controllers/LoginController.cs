using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly panelDbContext _context;

        public LoginController(panelDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            ViewData["username"] = DateTime.Now;
            return View(_context.Users.ToList());
        }

        public ActionResult Validate(string email, string password)
        {
            var _admin = _context.Users.Where(s => s.userEmail == email);
     
            if (_admin.Any())
            {
                if (_admin.Where(s => s.userPassword == password).Any())
                {
                    
                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }

        }




    }
}