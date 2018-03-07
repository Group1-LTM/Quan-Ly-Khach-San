using piccatinh.com.Areas.Administrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using piccatinh.com.Areas.Administrator.Models;
using piccatinh.com.Areas.Administrator.Controllers;
using Models;
using piccatinh.com.Areas.Administrator.Code;
using System.Web.Security;

namespace piccatinh.com.Areas.Administrator.Controllers
{
    public class LoginController : Controller
    {
        // GET: Administrator/Login
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            //var result = new AccountModel().Login(model.username, model.password);
            if (Membership.ValidateUser(model.username, model.password) && ModelState.IsValid)
            {
                //HelperSession.SetSession(new UserSession { username = model.username });
                FormsAuthentication.SetAuthCookie(model.username, model.rememberme);
                return RedirectToAction("Index", "HomeAdmin");

            }
            else
            {
                ModelState.AddModelError("", "Please Check Your Account!!");

            }
            return View(model);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");

        }
    }
}