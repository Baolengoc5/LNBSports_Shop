using LNBSports_Shop.Code.Session;
using LNBSports_Shop.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LNBSports_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Registrater()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModels model)
        {
            var result = new AccountModels().Login(model.UserName, model.Password);
            if(result == 1 && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession()
                {
                    UserName = model.UserName
                });
                return RedirectToAction("Index","Home");
            }
            else if(result == 2 && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession()
                {
                    UserName = model.UserName
                });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("","Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            return View(model);
        }
    }
}