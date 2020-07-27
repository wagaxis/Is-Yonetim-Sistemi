﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbcManagement.Business.Concrete;
using AbcManagement.Entities.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace AbcManagement.Website.Controllers
{
    public partial class HomeController : Controller
    {
        [Route("users", Name = "users")]
        public IActionResult Users()
        {
            const string methodCode = "009";
            return View();
        }

        public bool Save_User(User user)
        {
            const string methodCode = "010";
            using (var uop = new UserProcess(_context))
            {
                var saveUser = uop.Save(user);
                // Ekleme başarılı mı kontrolü yapılır.
                if (saveUser == true)
                {
                    return saveUser;
                }
                else
                {
                    return saveUser;
                }
            }
        }
        public bool Update_User(User user)
        {
            const string methodCode = "011";
            using (var uop = new UserProcess(_context))
            {
                var updateUser = uop.Update(user);
                // Güncelleme başarılı mı kontrolü yapılır.
                if (updateUser == true)
                {
                    return updateUser;
                }
                else
                {
                    return updateUser;
                }
            }
        }

        public bool Delete_User(User user)
        {
            const string methodCode = "012";
            using (var uop = new UserProcess(_context))
            {
                var deleteUser = uop.Delete(user);
                // Silme başarılı mı kontrolü yapılır.
                if (deleteUser == true)
                {
                    return deleteUser;
                }
                else
                {
                    return deleteUser;
                }
            }
        }

        public JsonResult List_User()
        {
            const string methodCode = "013";
            using (var uop = new UserProcess(_context))
            {
                var listUser = uop.List_Users(null);
                // Liste alınabildi mi kontrolü yapılır.
                if (listUser != null)
                {
                    return Json(listUser);
                }
                else
                {
                    return Json(null);
                }
            }
        }

        public JsonResult Find_User(User user)
        {
            const string methodCode = "014";
            using (var uop = new UserProcess(_context))
            {
                var findUser = uop.Find(w => w.UserId == user.UserId);
                // Kullanıcı bulunabildi mi kontrolü yapılır.
                if (findUser != null)
                {
                    return Json(findUser);
                }
                else
                {
                    return Json(null);
                }
            }
        }
    }
}
