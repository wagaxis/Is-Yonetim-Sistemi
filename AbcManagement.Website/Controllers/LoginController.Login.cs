using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AbcManagement.Business.Concrete;
using AbcManagement.Entities.Concreate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AbcManagement.Website.Controllers
{
    public partial class LoginController : Controller
    {
        ClaimsIdentity identity = null;
        bool isAuthenticated = false;
        dynamic login;

        [HttpPost]
        [AllowAnonymous]
        public IActionResult SignIn(User user)
        {
            int error = 0;
            // Eksik bilgi kontrolü yapılır.
            if (user != null && user.Email != null && user.Password != null)
            {
                using (var uop = new UserProcess(_context))
                {
                    var u = uop.List_Users(null);
                    // Liste alınabildi mi kontrolü yapılır.
                    if(u != null)
                    {
                        var log = u.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
                        // Kullanıcı kayıtlı mı kontrolü yapılır.
                        if (log != null)
                        {
                            identity = new ClaimsIdentity(new[] {
                                new Claim(ClaimTypes.Name, log.FirstName + " " + log.LastName),
                                new Claim(ClaimTypes.Role, log.IsAdmin.ToString()),
                                new Claim(ClaimTypes.Surname, log.UserId.ToString())
                                }, 
                                CookieAuthenticationDefaults.AuthenticationScheme
                            );
                            isAuthenticated = true;
                            error = 0;
                        }
                        else
                        {
                            error = 1;
                        }
                        // Login işleminin başarılı mı kontrolü yapılır ve session başlatılır.
                        if (isAuthenticated)
                        {
                            var principal = new ClaimsPrincipal(identity);

                            login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                                new AuthenticationProperties
                                {
                                    IsPersistent = true,
                                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                                });

                            return RedirectToAction("Index", "Home");
                        }
                        return RedirectToAction("Login", new { er = error });
                    }
                    else
                    {
                        return RedirectToAction("Login", new { methodCode = 001 ,message = "Kullanıcı bilgileri alınamadı." });
                    }
                }
            }
            else
            {
                return RedirectToAction("Login", new { methodCode = 001, message = "Eksik bilgi!" });
            }
        }
    }
}
