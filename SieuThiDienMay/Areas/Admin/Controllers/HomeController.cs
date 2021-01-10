using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SieuThiDienMay.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Error400()
        {
            return View();
        }
        public ActionResult _Error401()
        {
            return View();
        }
        public ActionResult _Error403()
        {
            return View();
        }
        public ActionResult _Error404()
        {
            return View();
        }
        public ActionResult _Error404_2()
        {
            return View();
        }
        public ActionResult _Error500()
        {
            return View();
        }
        public ActionResult _Error501()
        {
            return View();
        }
        public ActionResult _Error503()
        {
            return View();
        }
    }
}