using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbcManagement.Website.Controllers
{
    public partial class LoginController : Controller
    {
        [Route("register", Name = "register")]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
    }
}
