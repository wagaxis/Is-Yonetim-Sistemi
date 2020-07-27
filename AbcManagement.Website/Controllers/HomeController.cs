using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AbcManagement.Website.Models;
using AbcManagement.Business.Concrete;
using AbcManagement.DataAccess.ORMs.EF;
using Microsoft.AspNetCore.Authorization;

namespace AbcManagement.Website.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly string ControllerCode = "Ctrlr-001";
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            const string methodCode = "001";
            return View();
        }

        public IActionResult Login()
        {
            const string methodCode = "002";
            return RedirectToAction("Login", "Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
