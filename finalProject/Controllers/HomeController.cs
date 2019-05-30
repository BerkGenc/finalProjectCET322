using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using finalProject.Models;

namespace finalProject.Controllers
{
    public class HomeController : Controller
    {

        private readonly panelDbContext _context;

        public HomeController(panelDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Cihazlar()
        {
            ViewData["Message"] = "Your contact page.";
            DashboardViewModel dashboard = new DashboardViewModel();

            dashboard.device_count = _context.Device.Count();
            dashboard.normal_count = _context.Device.Where(m => m.deviceSituation == "Normal").Count();
            dashboard.maintenance_count = _context.Device.Where(m => m.deviceSituation == "Maintenance").Count();
            dashboard.unavailable_count = _context.Device.Where(m => m.deviceSituation == "Unavailable").Count();
            return View(dashboard);
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
