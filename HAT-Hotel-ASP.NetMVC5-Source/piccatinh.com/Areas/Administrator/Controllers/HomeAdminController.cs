using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace piccatinh.com.Areas.Administrator.Controllers
{
    [Authorize] //yeu cau phai dang nhap
    public class HomeAdminController : Controller
    {
        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}