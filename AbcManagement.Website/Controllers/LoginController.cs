using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbcManagement.DataAccess.ORMs.EF;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbcManagement.Website.Controllers
{
    public partial class LoginController : Controller
    {
        private readonly string ControllerCode = "Ctrlr-002";
        private readonly DatabaseContext _context;

        public LoginController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: LoginController[Route("login")]
        [HttpGet]
        [Route("login", Name = "login")]
        [AllowAnonymous]
        public ActionResult Login(string returnUrl, int er)
        {
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return View();
            }
            if (er == 1)
            {
                ViewBag.error = 1;
            }
            else
            {
                ViewBag.error = 0;

            }
            return View();
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

    }
}
