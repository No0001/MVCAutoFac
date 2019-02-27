using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacDemo.Controllers
{
    public class HomeController : Controller
    {
        private ITEST _test;

        public HomeController(ITEST test)
        {
            this._test = test;
        }

        public ActionResult Index()
        {
            var 覽趴 = _test.Demo();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}