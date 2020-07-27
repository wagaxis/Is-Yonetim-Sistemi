using System;
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
        // 0 = default
        // 1 = işlem başarılı
        // 2 = işlem başarısız

        public IActionResult Project(int process = 0)
        {
            const string methodCode = "003";
            if (process == 1)
            {
                ViewBag.process = 1;
            }
            else if(process == 2)
            {
                ViewBag.process = 2;

            }
            else
            {
                ViewBag.process = 0;
            }
            return View();
        }        

        public IActionResult Save_Project(Work work)
        {
            const string methodCode = "004";
            using (var wop = new WorkProcess(_context))
            {
                var saveWork = wop.Save(work);
                // Ekleme başarılı mı kontrolü yapılır.
                if (saveWork == true)
                {
                    return RedirectToAction("Project", new { process = 1 });
                }
                else
                {
                    return RedirectToAction("Project", new { process = 2 });
                }
            }
        }
        public bool Update_Project(Work work)
        {
            const string methodCode = "005";
            using (var wop = new WorkProcess(_context))
            {
                var updateWork = wop.Update(work);
                // Güncelleme başarılı mı kontrolü yapılır.
                if (updateWork == true)
                {
                    return updateWork;
                }
                else
                {
                    return updateWork;
                }
            }
        }

        public bool Delete_Project(Work work)
        {
            const string methodCode = "006";
            using (var wop = new WorkProcess(_context))
            {
                var deleteWork = wop.Delete(work);
                // Silme başarılı mı kontrolü yapılır.
                if (deleteWork == true)
                {
                    return deleteWork;
                }
                else
                {
                    return deleteWork;
                }
            }
        }

        public JsonResult List_Project()
        {
            const string methodCode = "007";
            using (var wop = new WorkProcess(_context))
            {
                var listWork = wop.List_Works(null);
                // Liste alınabildi mi kontrolü yapılır.
                if (listWork != null)
                {
                    return Json(listWork);
                }
                else
                {
                    return Json(null);
                }
            }
        }

        public JsonResult Find_Project(Work work)
        {
            const string methodCode = "008";
            using (var wop = new WorkProcess(_context))
            {
                var findWork = wop.Find(w => w.WorkId == work.WorkId);
                // İş bulunabildi mi kontrolü yapılır.
                if (findWork != null)
                {
                    return Json(findWork);
                }
                else
                {
                    return Json(null);
                }
            }
        }
    }
}
